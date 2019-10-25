using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMgr : MonoBehaviour {
	public string who;

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "slime") { 
			who = "slime";
		} else if (col.gameObject.tag == "lava") {
			who = "lava";
		} else if (col.gameObject.tag == "snail") {
			who = "snail";
		}
	}

	void Update() {
	}
}

