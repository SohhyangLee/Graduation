using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {
	public bool enableSpawn = false;
	public GameObject Enemy1;
	public GameObject Enemy2;

	void SpawnEnemy() {
		float randomX1 = Random.Range (-5.0f, 5.0f);
		float randomY1 = Random.Range (-6.0f, 6.0f);
		if (enableSpawn) {
			GameObject enemy1 = (GameObject)Instantiate(Enemy1, new Vector3(randomX1, randomY1, 0f), Quaternion.identity);
		}
	}
	// Use this for initialization
	void Start () {
		SpawnEnemy ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
