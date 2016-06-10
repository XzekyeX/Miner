using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject plane = GameObject.CreatePrimitive (PrimitiveType.Plane);
		Instantiate (plane);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
