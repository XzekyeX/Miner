using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float distance = 1.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //RaycastHit hit;

        //if (Physics.Raycast(transform.position, -Vector3.up, out hit, distance))
        //    print("Found an object - distance: " + hit.distance);
    }
}
