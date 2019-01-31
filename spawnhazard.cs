using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnhazard : MonoBehaviour {

	public GameObject[] hazard;
	public Vector3 spawnValues;
	public float startWait;
	public float wavewait;

	int randEnemy;

	void Start(){
		StartCoroutine (SpawnWaves());
	}

	IEnumerator SpawnWaves(){
		yield return new WaitForSeconds (startWait);
		while(true){
			randEnemy = Random.Range(0,3);
			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x,spawnValues.x),spawnValues.y,spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (hazard[randEnemy],spawnPosition,spawnRotation);
			yield return new WaitForSeconds (Random.Range(0,wavewait));
		}

	}

}
