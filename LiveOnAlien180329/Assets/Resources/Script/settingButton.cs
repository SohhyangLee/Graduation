using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingButton : MonoBehaviour {
	public GameObject settingPanel;
	public Slider soundSlider;
	public AudioSource bgm;

	// Use this for initialization
	void Awake () {
		settingPanel.SetActive (false);
	}
	// Update is called once per frame
	public void exitSetActive() {
		settingPanel.SetActive (!settingPanel.active);
	}

	public void playSound(){
		GameObject.Find ("audioButton").GetComponent<AudioSource> ().Play();
	}

	public void volumeSet(){
		bgm.volume = soundSlider.value;
	}
}
