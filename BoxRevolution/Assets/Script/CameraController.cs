using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject target;
    public GameObject[] positions;
    private int index = 0;
    public float speed = 2;
    private RaycastHit hit;

    void FixedUpdate()
    {
        transform.LookAt(target.transform);

        //check for collision
        if (!Physics.Linecast(target.transform.position, positions[index].transform.position))
        {
            transform.position = Vector3.Lerp(transform.position, positions[index].transform.position, speed*Time.deltaTime);
        }else if (Physics.Linecast(target.transform.position, positions[index].transform.position, out hit))
        {
            transform.position = Vector3.Lerp(transform.position, hit.point, speed * 2 * Time.deltaTime);
             
        }
    }

}
