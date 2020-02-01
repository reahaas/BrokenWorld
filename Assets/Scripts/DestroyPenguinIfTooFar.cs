using UnityEngine;

public class DestroyPenguinIfTooFar : MonoBehaviour
{
    public float distance;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        
    }


    void Update()
    {
        if (Vector3.Distance(startPosition, transform.position) > distance)
            Destroy(gameObject);

    }

    private void OnDestroy()
    {
        PenguinCounter.count -= 1;
    }
}
