using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    public float mouseSensitivity = 2.0f;
    public float VerticalAngleLimit = 60.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 9.81F;
    private float VerticalRot = 0;
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Cursor has been released!");
        }
        if (Cursor.lockState == CursorLockMode.Locked && Input.GetMouseButtonDown(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Cursor has been locked!");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rotX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotX, 0);

        VerticalRot -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        VerticalRot = Mathf.Clamp(VerticalRot, -VerticalAngleLimit, VerticalAngleLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(VerticalRot, 0, 0);

        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;
        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);
        speed = transform.rotation * speed;
        CharacterController cc = GetComponent<CharacterController>();
        if (cc.isGrounded && Input.GetButton("Jump"))
        {
            speed.y += jumpSpeed;
        }
        speed.y -= gravity * Time.deltaTime;
        cc.Move(speed * Time.deltaTime);
    }
}
