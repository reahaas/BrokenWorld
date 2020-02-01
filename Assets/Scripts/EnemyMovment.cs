using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public GameObject enemy;
    public Animator anim;



    void Start()
    {
        transform.rotation = Quaternion.AngleAxis(Random.Range(90, 120), Vector3.up);
        this.anim.SetTrigger("walk");
    }

    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
            return;

        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
