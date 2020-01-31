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
        Vector3 vel;

        vel = Random.insideUnitSphere * speed;
        vel.y = 0f;
        transform.Translate(vel * Time.deltaTime);

    }
}
