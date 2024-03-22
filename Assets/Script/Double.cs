using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Double : MonoBehaviour
{
    public ManagerLitCut litCut;

    public Shoot shoot;

    public GameObject cut;
    public GameObject litCutPrefab1;
    public GameObject litCutPrefab2;


    public Transform divleft;
    public Transform divright;

    public float force;

    //private float val1;
    //private float val2;

    Touch touch;

    
    // Update is called once per frame
    void Update()
    { 
        // mov = new Vector2(val1, val2);
        //tCut.eulerAngles = mov;
        //Vector2 mov1 = new Vector2(0, 0);

        if (shoot.tu == false && Input.touchCount > 0)
        {
            Debug.Log("www");
            StartCoroutine(Div());
        }
    }

    /*void Div()
    {
        var bullet = Instantiate(litCutPrefab, divleft.position, divleft.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = divleft.up * force;


         /*GameObject litcut1 = Instantiate(litCutPrefab, divleft.position, divleft.rotation);
         Rigidbody2D rb = litcut1.GetComponent<Rigidbody2D>();
         rb.AddForce(divleft.forward*force, ForceMode2D.Impulse);

         GameObject litcut2 = Instantiate(litCutPrefab, divright.position, divright.rotation);
         Rigidbody2D rb2 = litcut2.GetComponent<Rigidbody2D>();
         rb2.AddForce(divright.forward * force, ForceMode2D.Impulse);

        Destroy(this.gameObject);

    }*/

    IEnumerator Div()
    {
        yield return new WaitForSeconds(0.1f);

        if (shoot.tu == false && Input.touchCount == 1)
        {
            
            Debug.Log("xxx");

            for (int i = 0; i < 1; i++)
            {
                GameObject bullet1 = Instantiate(litCutPrefab1, divleft.position, divleft.rotation);
                bullet1.GetComponent<Rigidbody2D>().velocity = divleft.up * force;

                GameObject bullet2 = Instantiate(litCutPrefab2, divright.position, divright.rotation);
                bullet2.GetComponent<Rigidbody2D>().velocity = divright.up * force;

                litCut.lCut.Add(bullet1);
                litCut.lCut.Add(bullet2);
            }

            Destroy(this.gameObject);
        }
    }
}
