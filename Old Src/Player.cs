using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
public class Player : MonoBehaviour
{
    public Transform camera;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float far = 10F;
    public float lookSpeed = 10F;
    public float smooth = 2.0F;
    public float rotSpeed = 1.0F;
    public bool firstPerson = true;
    private Vector3 dir;
    private Vector3 rot = Vector3.zero;
    void FixedUpdate()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
            if (Input.GetButton("Jump"))
                dir.y = jumpSpeed;
        }
        dir.y -= gravity * Time.deltaTime;
        controller.Move(dir * Time.deltaTime);
        if (Input.GetKey("e"))
        {
            rot.y += rotSpeed;
        }
        if (Input.GetKey("q"))
        {
            rot.y -= rotSpeed;
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rot), smooth);
    }

    void LateUpdate()
    {
        camera.transform.position = transform.position + new Vector3(0, far, 0);
        camera.transform.rotation = transform.rotation;
    }

}
