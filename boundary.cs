using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour {

	public float xMin, xMax, tilt;

	// Use this for initialization

	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().position = new Vector3 (
			Mathf.Clamp(GetComponent<Rigidbody>().position.x,xMin,xMax),
			3.7f,
			-1.64f
			);

		GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f,Mathf.Clamp(90.0f+GetComponent<Rigidbody>().position.x*-tilt,70.0f,110.0f),-25.595f);
		
		
	}
}
