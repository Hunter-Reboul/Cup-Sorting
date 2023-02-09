using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public Text timer;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = 60.0f - (Time.time - startTime);
        
        if (t < 0.0f)
        {
            timer.text = "Time's Up!";
            GameObject red = GameObject.Find("Red Marble");
            Destroy(red);
            GameObject blue = GameObject.Find("Blue Marble");
            Destroy(blue);
        }
        else
        {
            string seconds = t.ToString("f0");
            timer.text = seconds;
        }
    }
}
