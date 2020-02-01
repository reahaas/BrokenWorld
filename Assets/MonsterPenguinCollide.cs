using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPenguinCollide : MonoBehaviour
{
    public Transform explosionPrefab;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(("Collision !"));
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        
        GetComponent<AudioSource>().Play();
        Instantiate(explosionPrefab, position, rotation);
        Destroy(gameObject);
    }
}
