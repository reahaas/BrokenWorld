using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovment : MonoBehaviour
{
    public GameObject penguin;
    public float speed = 10f;
    private GameObject _lookAt;
    private Boolean isMoveToCenter = false;
    private float movmentInterval = 5;
    private float time = 0;

    public void SetLookAt(GameObject lookAt)
    {
        _lookAt = lookAt;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
            return;
        ControllPenguin();

    }

    void ControllPenguin()
    {
        time += Time.deltaTime;

        if (time > movmentInterval)
        {
            isMoveToCenter = !isMoveToCenter;
            time = UnityEngine.Random.Range(3f, 5f);

        }

        float added = 0;
        float returnHomeBios = Vector3.Distance(transform.position, Vector3.zero);
        if (returnHomeBios > 15)
        {
            added = 1;
        }
        float smallRotate = UnityEngine.Random.Range(-1, 2 + added);


        if (isMoveToCenter)
        {
            smallRotate -= 1;
        }
        else
        {
            smallRotate += 1;
        }
        transform.Rotate(0, smallRotate, 0);
        transform.Translate(Vector3.left * Time.deltaTime);

        // showDegubLines();

    }

    private void showDegubLines()
    {
        Vector3 targetDirection = _lookAt.transform.position - transform.position;
        float singleStep = speed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        newDirection = transform.forward;
        Debug.DrawRay(transform.position, newDirection, Color.red);

    }

    private float getTurnEngle(float y)
    {
        if (y >= 180)
        {
            return 1f;
        }
        else
        {
            return -1f;
        }
    }


}
