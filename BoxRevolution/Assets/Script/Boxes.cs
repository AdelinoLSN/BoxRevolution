using System;
using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour
{
    public GameObject box;
    public GameObject alvo;
    public Transform teto;
    System.Random random = new System.Random();

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 20f);

    }

    void Spawn()
    {
        StartCoroutine(CreateBoxes());
    }

    IEnumerator CreateBoxes()
    {
        Box1();
        yield return new WaitForSeconds(10);
        Box2();
    }

    void Box1()
    {
        int x = random.Next(-7, 7);
        int z = random.Next(-7, 7);
        Instantiate(box, new Vector3(x, 15, z), teto.rotation);
    }

    void Box2()
    {
        Instantiate(box, new Vector3(alvo.transform.position.x, 15, alvo.transform.position.z), teto.rotation);
    }


}
