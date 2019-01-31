using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour {

	public static AudioClip hitsound, itemsound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		hitsound = Resources.Load<AudioClip>("hit");
		itemsound = Resources.Load<AudioClip>("item");
		audioSrc = GetComponent<AudioSource>();
		
	}


	// Update is called once per frame
	public static void PlaySound (string clip){

		switch (clip){
		case "hit":
			audioSrc.PlayOneShot (hitsound);
			break;
		case "item":
			audioSrc.PlayOneShot (itemsound);
			break;

		}


	}
}
