using System.Collections;
using System.Collections.Generic;
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
                //Instantiate(myPrefab, new Vector3(Random.Range(i, j), 0, Random.Range(i, j)), Quaternion.identity);
                Instantiate(myPrefab, new Vector3(i + Random.Range(0f, 1f), 0, j + Random.Range(0f, 1f)), Quaternion.identity);
            }
        }
    }

    void Update()
    {
        
    }

    public Vector3 getRandomVectorLocation()
    {
        int maxLimit = randomRange;
        int minLimit = randomRange * (-1);
        int x = Random.Range(minLimit, maxLimit);
        int z = Random.Range(minLimit, maxLimit);
        return new Vector3(x, 1, z);
    }

}
