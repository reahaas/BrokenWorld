using UnityEngine;

public class CitizenGenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject lookAt;
    public int citizentsCount = 4;
    public int randomRange = 5;


    void Start()
    {
        for (float i = 0; i < citizentsCount; i += 2)
        {
            for (float j = 0; j < citizentsCount; j += 2)
            {
                PenguinMovment temp = Instantiate(myPrefab,
                    new Vector3(transform.position.x + i + Random.Range(0f, 1f), transform.position.y, transform.position.z + j + Random.Range(0f, 1f)), 
                    Quaternion.identity).GetComponent<PenguinMovment>();
                temp.SetLookAt(lookAt);

                temp.transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);

                PenguinCounter.count += 1;

            }
        }
    }

}
