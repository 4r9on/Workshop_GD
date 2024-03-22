using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public GameObject reload;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut")
        {
            Destroy(this.gameObject);
            reload.SetActive(true);
        }

        if (collision.gameObject.tag == "LCut")
        {
            Destroy(this.gameObject);
        }
    }
}
