using System;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    public GameObject box;
    public Transform teto;
    public float spawnTime = 1f;
    System.Random random = new System.Random();

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        int x = random.Next(-7, 7);
        int z = random.Next(-7, 7);
        Instantiate(box, new Vector3(x, 15, z), teto.rotation);
    }
}
