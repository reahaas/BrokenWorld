using UnityEngine;

public class CitizenGenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public int citizentsCount = 4;
    public int randomRange = 5;


    void Start()
    {
        for (float i = 0; i < citizentsCount; i+=2)
        {
            for (float j = 0; j < citizentsCount; j+=2)
            {
                Instantiate(myPrefab, new Vector3(i + Random.Range(0f, 1f), transform.position.y, j + Random.Range(0f, 1f)), Quaternion.identity);
            }
        }
    }

}
