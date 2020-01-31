using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovment : MonoBehaviour
{
    public GameObject penguin;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ControllPenguin();

    }

    void ControllPenguin()
    {

        int smallRotate = UnityEngine.Random.Range(-1, 2);

        transform.Rotate(0, smallRotate, 0);

        transform.Translate(Vector3.left * Time.deltaTime);



        float singleStep = speed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, Vector3.zero, singleStep, 0f);

        transform.rotation = Quaternion.LookRotation(newDirection);

    }


}
