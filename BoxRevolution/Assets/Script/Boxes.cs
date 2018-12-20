using System;
using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour
{
    public GameObject box;
    public GameObject alvo;
    public Transform teto;
    System.Random random = new System.Random();

    private float first;
    private float delay;

    // Use this for initialization
    void Start()
    {
        first = 0f;
        delay = Settings.TempoCaixas * 2f;
        InvokeRepeating("Spawn", first, delay);

    }

    void Spawn()
    {
        StartCoroutine(CreateBoxes());
    }

    IEnumerator CreateBoxes()
    {
        Box1();
        yield return new WaitForSeconds(Settings.TempoCaixas);
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
