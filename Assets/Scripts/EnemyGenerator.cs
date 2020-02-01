using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public int Count = 4;
    public int randomRange = 5;


    void Start()
    {
        for (float i = 0; i < Count; i+=2)
        {
            for (float j = 0; j < Count; j+=2)
            {
                Instantiate(myPrefab, new Vector3(transform.position.x + i + Random.Range(0f, 1f), transform.position.y, transform.position.z + j + Random.Range(0f, 1f)), Quaternion.identity);
            }
        }
    }

}
