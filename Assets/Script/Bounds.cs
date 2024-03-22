using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bounds : MonoBehaviour
{
    public int bound;
    public TextMeshProUGUI numberBounds;

    public GameObject reload;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numberBounds.text = "" + bound;

        if(bound == 0)
        {
            reload.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            bound--;
        }
    }

}
