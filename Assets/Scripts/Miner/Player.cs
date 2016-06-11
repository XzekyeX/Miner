using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
public class Player : MonoBehaviour
{
    public float x = 0, y = 0, z = 0;
    public float speed = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h != 0 || v != 0)
        {
            x += h * speed * Time.deltaTime;
            z += v * speed * Time.deltaTime;
        }
        gameObject.transform.position = new Vector3(x, y, z);
    }
}
