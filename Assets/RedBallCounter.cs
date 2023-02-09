using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class RedBallCounter : MonoBehaviour
{
    public Text RedBallCount;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RedBallCount.text = counter.ToString();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Red Cup Bottom")
        {
            counter++;
            RedBallCount.text = counter.ToString();
        }
    }
}

