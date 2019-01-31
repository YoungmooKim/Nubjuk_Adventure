using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		if (i < Input.touchCount){
			Time.timeScale = 1;
			SceneManager.LoadScene ("gamescene");
		}
	}

}
