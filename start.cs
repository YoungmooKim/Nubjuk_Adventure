using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
		public GameObject R,L,bgm;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		R.gameObject.SetActive (false);
		L.gameObject.SetActive (false);
		bgm.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		if (i < Input.touchCount){
			Time.timeScale = 1;
			R.gameObject.SetActive (true);
			L.gameObject.SetActive (true);
			bgm.gameObject.SetActive (true);
			Destroy(gameObject);
		}
		
	}
}
