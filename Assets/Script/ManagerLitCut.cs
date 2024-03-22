using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLitCut : MonoBehaviour
{
    public List<GameObject> lCut;
    [SerializeField]
    private GameObject realod;

    void Start()
    {
        Debug.Log(lCut.Count);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (lCut.Count == 0)
        {
            realod.SetActive(true);
        }
    }
}
