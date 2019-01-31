using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamesystem : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "phone"){
			Gpasystem.Gpa -=1;
		}
		else if(other.tag=="book"){
			Gpasystem.Gpa +=2;
		}
		else if(other.tag=="hotsix"){
			healthsystem.health -=1;

		}
		else if(other.tag=="soju"){
			Gpasystem.Gpa -=1;
			healthsystem.health -=1;

		}
		else if(other.tag=="dumbel"){
			healthsystem.health +=2;
		}

	}

	}