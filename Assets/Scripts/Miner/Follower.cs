using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour
{
    public Transform camera;
    public Vector3 offset;
    public float rotSpeed = 1.0F;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        camera.position = transform.position + offset;
        camera.rotation = Quaternion.Lerp(camera.rotation, transform.rotation, rotSpeed);
    }
}
