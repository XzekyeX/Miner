using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public Transform CameraTransform;
	private Vector3 moveDirection = Vector3.zero;

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			Quaternion inputRotation = Quaternion.LookRotation (Vector3.ProjectOnPlane (CameraTransform.forward, Vector3.up), Vector3.up);
			moveDirection = inputRotation * transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
			
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}




//public class PlayerMovement : MonoBehaviour {
//	
//	public float speed;
//	public float jump;
//	private float x = 0, y = 0, z = 0;
//	private Rigidbody rb;
//	
//	
//	public bool allowjump = true;
//	
//	public Transform CameraTransform;
//	void Start ()
//	{
//		rb = GetComponent<Rigidbody>();
//	}
//	
//	void Update()
//	{
//		
//	}
//	
//	void OnCollisionEnter(Collision collision){
//		allowjump = true;
//	}
//	void FixedUpdate ()
//	{
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//		
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//		Quaternion inputRotation = Quaternion.LookRotation (Vector3.ProjectOnPlane (CameraTransform.forward, Vector3.up), Vector3.up);
//		movement = inputRotation * movement;
//
//		if (moveHorizontal != 0 || moveVertical != 0)
//		{
//			x += moveHorizontal * speed * Time.deltaTime;
//			z += moveVertical * speed * Time.deltaTime;
//		}
//		gameObject.transform.position = new Vector3(x, y, z);
//		//rb.AddForce (movement * speed);
//		
//		if (Input.GetKey ("space") & allowjump) {
//			rb.AddForce (0.0f, jump, 0.0f);
//			allowjump = false;
//		}
//	}
//}