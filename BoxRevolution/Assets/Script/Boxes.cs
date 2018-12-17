using System;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    public GameObject box;
    public GameObject alvo;
    public Transform teto;
    System.Random random = new System.Random();

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 6f, 6f);
        
    }

    void Spawn()
    {
        int x = random.Next(-7, 7);
        int z = random.Next(-7, 7);
        Instantiate(box, new Vector3(x, 15, z), teto.rotation);
        Instantiate(box, new Vector3(alvo.transform.position.x, 15, alvo.transform.position.z), teto.rotation);
    }

   
}
