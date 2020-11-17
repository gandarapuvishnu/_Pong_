using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float x = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(x, 0.0f, 0.0f);
            Debug.Log("Down");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(-x, 0.0f, 0.0f);
            Debug.Log("Up");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Upper Boundary")
        {
            this.gameObject.transform.position = new Vector3(1.97f, 0.0f, -11.0f);
        }
        else if(collision.gameObject.name == "Lower Boundary")
        {
            this.gameObject.transform.position = new Vector3(5.93f, 0.0f, -11.0f);
        }
    }

}
