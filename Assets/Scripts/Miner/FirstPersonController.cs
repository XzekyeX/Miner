using UnityEngine;
using System.Collections;
/**
 * @author Zekye
 *
 */
[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    public float mouseSensitivity = 2.0f;
    public float VerticalAngleLimit = 60.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = -9.81F;
    public bool camLock = false;
    private float verticalRot = 0;
    private float verticalVelocity = 0;
    private CharacterController cc;
    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = camLock ? CursorLockMode.Locked : CursorLockMode.None;
        float rotX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotX, 0);

        verticalRot -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRot = Mathf.Clamp(verticalRot, -VerticalAngleLimit, VerticalAngleLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRot, 0, 0);

        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        verticalVelocity += gravity * Time.deltaTime;
        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);
        speed = transform.rotation * speed;
        if (cc.isGrounded && Input.GetButton("Jump"))
        {
            verticalVelocity = jumpSpeed;
        }
        cc.Move(speed * Time.deltaTime);
    }
}
