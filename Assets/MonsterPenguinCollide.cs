using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPenguinCollide : MonoBehaviour
{
    public Transform explosionPrefab;
    ArrayList badGuyNames = new ArrayList();

    void Start()
    {
        badGuyNames.Add("Boximon");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        String bumpIntoName = collision.collider.name;
        if (isBadGuy(bumpIntoName))
        {
            print("Detected collision between " + gameObject.name + " and " + bumpIntoName);
            print("There are " + collision.contacts.Length + " point(s) of contacts");
            print("Their relative velocity is " + collision.relativeVelocity);
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;

            var clip = GetComponent<AudioSource>().clip;
            PlaySound(clip);

            var explosion = Instantiate(explosionPrefab, position, rotation);
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            Destroy(explosion.gameObject, 2.0f);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        var soundEntity = new GameObject("ExplosionSound");
        var audioSource = soundEntity.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(soundEntity, clip.length + 1.0f);
    }

    private bool isBadGuy(string bumpIntoName)
    {
        for (int i = 0; i < badGuyNames.Count; i++)
        {
            String badDude = badGuyNames[i].ToString();
            if (bumpIntoName.ToLower().Contains(badDude.ToLower()))
                return true;
        }

        return false;
    }
}
