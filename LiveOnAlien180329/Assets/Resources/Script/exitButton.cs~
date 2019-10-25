using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButton : MonoBehaviour {
	public GameObject exitPanel;

	void Awake() {
		exitPanel.SetActive (false);
	}

	public void exitSetActive() {
		exitPanel.SetActive (true);
	}

	public void playSound(){
		GameObject.Find ("audioButton").GetComponent<AudioSource> ().Play();
	}
}
