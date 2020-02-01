using UnityEngine;

public class CitizenGenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject lookAt;
    public int citizentsCount = 4;
    public int randomRange = 5;


    void Start()
    {
        for (float i = 0; i < citizentsCount; i+=2)
        {
            for (float j = 0; j < citizentsCount; j+=2)
            {
<<<<<<< HEAD
                PenguinMovment temp = Instantiate(myPrefab,
                    new Vector3(i + Random.Range(0f, 1f),
                    transform.position.y, j + Random.Range(0f, 1f)), Quaternion.identity).GetComponent<PenguinMovment>();
                temp.SetLookAt(lookAt);
=======
                Instantiate(myPrefab, new Vector3(transform.position.x + i + Random.Range(0f, 1f), transform.position.y, transform.position.z + j + Random.Range(0f, 1f)), Quaternion.identity);
>>>>>>> master
            }
        }
    }

}
