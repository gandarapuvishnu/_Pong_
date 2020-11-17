using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int p_sc = 0;
    private int o_sc = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            p_sc += 1;
            GameObject.Find("Player score").GetComponentInChildren<Text>().text = 
                "Player score\n\n\t" + p_sc.ToString();

            Debug.Log("Player score incremented.");
        }
        else if (collision.gameObject.tag == "Opponent")
        {
            o_sc += 1;
            GameObject.Find("Opponent score").GetComponentInChildren<Text>().text =
                "Opponent score\n\n\t" + o_sc.ToString();

            Debug.Log("Opponent score incremented.");
        }
    }
}
