using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Cube);
        head.transform.position = new Vector3(0, 0.5F, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
