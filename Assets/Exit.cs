using UnityEngine;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

public class Exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.Application.Quit();
        }
    }
}
