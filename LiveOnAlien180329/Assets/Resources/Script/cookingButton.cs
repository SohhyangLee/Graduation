using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookingButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void playSound(){
		GameObject.Find ("audioButton").GetComponent<AudioSource> ().Play();
	}

	public void playSound2(){
		GameObject.Find ("audioButton2").GetComponent<AudioSource> ().Play();
	}
}
