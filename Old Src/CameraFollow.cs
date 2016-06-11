using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform lookAt;
	public bool isEnabled;
	private bool smooth = true;
	private float smoothSpeed = 0.125f;
	public Vector3 offset = new Vector3(0,0,-6.5f);

	// Update is called once per frame
	void LateUpdate () {
		Vector3 desiredPosition = lookAt.transform.position + offset;

		if (isEnabled) {
			if(smooth) {
				transform.position = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			}
			else {
				transform.position = desiredPosition;
			}
		}
	}
}
