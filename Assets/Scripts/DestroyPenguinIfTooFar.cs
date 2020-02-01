using UnityEngine;

public class DestroyPenguinIfTooFar : MonoBehaviour
{
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        
    }


    void Update()
    {
        if (Vector3.Distance(startPosition, transform.position) > 10)
            Destroy(gameObject);

    }

    private void OnDestroy()
    {
        PenguinCounter.count -= 1;
    }
}
