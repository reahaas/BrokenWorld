using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public int Count = 4;
    public float randomRange;


    void Start()
    {
        for (float i = 0; i < Count; i+=0.9f)
        {
            for (float j = 0; j < Count; j+=0.9f)
            {
                Instantiate(myPrefab, new Vector3(
                    transform.position.x + i + Random.Range(0f, randomRange),
                    transform.position.y,
                    transform.position.z + j + Random.Range(0f, randomRange)),
                    Quaternion.identity);
            }
        }
    }

}
