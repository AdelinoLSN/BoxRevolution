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
        Instantiate(box, new Vector3(0, 15, 0), teto.rotation);
    }

    
    // Update is called once per frame
    void Update () {
        
    }
}
