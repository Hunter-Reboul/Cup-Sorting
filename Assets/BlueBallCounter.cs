using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class BlueBallCounter : MonoBehaviour
{
    public Text BlueBallCount;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        BlueBallCount.text = counter.ToString();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Blue Cup Bottom")
        {
            counter++;
            BlueBallCount.text = counter.ToString();
        }
    }
}
