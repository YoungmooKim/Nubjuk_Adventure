using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gpasystem : MonoBehaviour {

	public GameObject gpa1, gpa2, gpa3, gpa4, gameOver, bgm;
	public static int Gpa;

	// Use this for initialization
	void Start () {

		Gpa = 4;
		gpa1.gameObject.SetActive (true);
		gpa2.gameObject.SetActive (true);
		gpa3.gameObject.SetActive (true);
		gpa4.gameObject.SetActive (true);
		gameOver.gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Gpa > 4)
			Gpa = 4;

		switch (Gpa) {
			case 4 :
			gpa1.gameObject.SetActive (true);
			gpa2.gameObject.SetActive (true);
			gpa3.gameObject.SetActive (true);
			gpa4.gameObject.SetActive (true);
			break;
			case 3 :
			gpa1.gameObject.SetActive (true);
			gpa2.gameObject.SetActive (true);
			gpa3.gameObject.SetActive (true);
			gpa4.gameObject.SetActive (false);
			break;
			case 2 :
			gpa1.gameObject.SetActive (true);
			gpa2.gameObject.SetActive (true);
			gpa3.gameObject.SetActive (false);
			gpa4.gameObject.SetActive (false);
			break;
			case 1 :
			gpa1.gameObject.SetActive (true);
			gpa2.gameObject.SetActive (false);
			gpa3.gameObject.SetActive (false);
			gpa4.gameObject.SetActive (false);
			break;
			case 0 :
			gpa1.gameObject.SetActive (false);
			gpa2.gameObject.SetActive (false);
			gpa3.gameObject.SetActive (false);
			gpa4.gameObject.SetActive (false);
			bgm.gameObject.SetActive (false);
			gameOver.gameObject.SetActive (true);
			Time.timeScale = 0;
			break;
		}
	}
}
