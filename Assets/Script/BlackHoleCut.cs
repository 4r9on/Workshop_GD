using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleCut : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rbCut;
    [SerializeField]
    private float vel;

    private void Start()
    {
        rbCut = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Hole"))
        {
            rbCut.velocity = new Vector3(0, vel);
        }
    }
}
