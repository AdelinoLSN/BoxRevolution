using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Boxes : MonoBehaviour {
    public GameObject box;
    public Transform teto;

    

    // Use this for initialization
    void Start () {
        Instantiate(box,teto.position,teto.rotation);
    }

    
    // Update is called once per frame
    void Update () {
        
    }
}
