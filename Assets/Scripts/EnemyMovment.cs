using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public GameObject enemy;
    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up);
        this.anim.SetTrigger("walk");
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
            return;
        float currentengle = transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.AngleAxis(Random.Range(currentengle -1, currentengle +2), Vector3.up);
        transform.Translate(Vector3.forward * Time.deltaTime);
        
    }
}
