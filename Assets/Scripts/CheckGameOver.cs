using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if (PenguinCounter.count == 0 && Time.frameCount > 30)
            Application.Quit();

    }
}
