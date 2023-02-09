using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class BlueCollider : MonoBehaviour
{
    
    async void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Blue Cup Bottom")
        {
            gameObject.SetActive(false);
            await Task.Delay(500);
            gameObject.SetActive(true);
            this.transform.position = new Vector3(1.0f, 0.5f, -4.0f);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
