using UnityEngine;
using System.Collections;

public class SmoothLookAt : MonoBehaviour
{
    public bool smooth = true;
    public float damping = 6.0F;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (smooth)
            {
                // Look at and dampen the rotation
                Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            }
            else
            {
                // Just lookat
                transform.LookAt(target);
            }
        }
    }
}
