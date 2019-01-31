using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nubjuk : MonoBehaviour {
	public float moveSpeed = 10;
	public Transform character;


	private float ScreenWidth;

	// Use this for initialization
	void Start () {
		ScreenWidth = Screen.width;

	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		while (i < Input.touchCount){
			if(Input.GetTouch(i).position.x > ScreenWidth / 2){
				RunCharacter(new Vector3(0.0f,0.0f,1.0f));
			}
			if(Input.GetTouch(i).position.x < ScreenWidth / 2){
				RunCharacter(new Vector3(0.0f,0.0f,-1.0f));
			}
			++i;
		}
		
	}


	private void RunCharacter(Vector3 direction){
		character.Translate(direction * moveSpeed*Time.deltaTime);
	}
}
