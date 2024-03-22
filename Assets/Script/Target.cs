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
        if (collision.gameObject.tag == "Target1")
        {
            Debug.Log("win");
            oneTarget = true;
        }

        if (collision.gameObject.tag == "Target2")
        {
            Debug.Log("win");
            twoTarget = true;
        }

        if (collision.gameObject.tag == "Target3")
        {
            Debug.Log("win");
            threeTarget = true;
        }




    }
}
