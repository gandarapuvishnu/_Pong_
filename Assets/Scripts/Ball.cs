using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float z, x;

    // Start is called before the first frame update
    void Start()
    {
        reset();
    }

    private void reset()
    {
        z = -3.0f;
        x = 5.0f;
        this.gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        Debug.Log("Reset");

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(x*Time.deltaTime, 0, z * Time.deltaTime);

        if ((this.gameObject.transform.position.z > 8.8f) || (this.gameObject.transform.position.z < -11.0f) )
        {
            Debug.Log("Going beyond.");
            reset();            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            z = -z;
            Debug.Log("Collision with player.");

        }
        else if (collision.gameObject.tag == "Opponent")
        {
            z = -z;
            Debug.Log("Collision with opponent.");
        }
        else if(collision.gameObject.tag == "Boundary")
        {
            x = -x;
            Debug.Log("Collision with boundary.");
        }
    }
}
