using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed;

    private Animator anim;


    private enum MovementState {
        ChargingForward,
        Turning
    };

    MovementState movementState;

    void Start()
    {
        movementState = MovementState.ChargingForward;

        anim = GetComponent<Animator>();

        transform.rotation = Quaternion.AngleAxis(Random.Range(90, 120), Vector3.up);

        //anim.SetTrigger("Run W Root");

        StartCoroutine(VerifyNotStuck());
    }

    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
            return;

        if (movementState == MovementState.ChargingForward)
        {            
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
    
    // if no much movement in one second (probably stuck in a wall) start rotating.
    private IEnumerator VerifyNotStuck()
    {

        while (true)
        {
            var prevPos = transform.position;

            yield return new WaitForSeconds(1);

            if (movementState == MovementState.Turning)
                continue;            

            float distance = Vector3.Distance(prevPos, transform.position); 
            if(distance<0.1)
            {
                prevPos = transform.position;
                movementState = MovementState.Turning;

                StartCoroutine(RotateSome());

            }
        }
    }


    private IEnumerator RotateSome()
    {

        float time = 2f;
        float elapsedTime = 0.0f;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 100f, 0f));

        while (elapsedTime < time)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, (elapsedTime / time));

            elapsedTime += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        movementState = MovementState.ChargingForward;
        yield return 0;
    }
}
