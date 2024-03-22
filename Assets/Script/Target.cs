using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool oneTarget = false;
    public bool twoTarget = false;
    public bool threeTarget = false;

    public GameObject ui;

    private void Update()
    {
        if(oneTarget == true || twoTarget == true && threeTarget == true)
        {
            ui.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut")
        {
            Debug.Log("win");
            oneTarget = true;
        }

        if (collision.gameObject.tag == "LitCut")
        {
            Debug.Log("win");
            twoTarget = true;
        }

        if (collision.gameObject.tag == "LitCut")
        {
            Debug.Log("win");
            threeTarget = true;
        }




    }
}
