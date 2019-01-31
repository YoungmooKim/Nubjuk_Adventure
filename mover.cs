using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
	}

	void Update (){
		transform.Translate(0.0f,speed*Time.deltaTime,0.0f);
	}	

}
