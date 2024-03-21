using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Camera main;
    public Vector3 mousePos;

    void Update()
    {
        //mousePos = Input.mousePosition;

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Deg2Rad;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        //mousePos = Input.mousePosition;
    }
}
