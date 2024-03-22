using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rbCut;
    [SerializeField]
    private float vel;

    public GameObject reload;

    private void Start()
    {
        rbCut = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Cut") || collision.CompareTag("LCut"))
        {
            rbCut.velocity = new Vector3(0, vel);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cut")
        {
            Destroy(this.gameObject);
            reload.SetActive(true);
        }

        if (collision.gameObject.tag == "LCut")
        {
            reload.SetActive(true);
        }
    }
}
