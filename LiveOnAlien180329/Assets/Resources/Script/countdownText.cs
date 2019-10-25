using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownText : MonoBehaviour {

	public GameObject blindPanel;
	public Text CountDown;
	public float TimeCost = 3.0f;
	bool isCountDown = true;

	// Use this for initialization
	void Awake () {
		blindPanel.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (isCountDown) {
			TimeCost -= Time.deltaTime;
			CountDown.text = ""+((int)TimeCost+1);

			if (TimeCost < 0) {
				CountDown.text = "";
				Color color = CountDown.color;
				color.a = 0.0f;
				CountDown.color = color;
				blindPanel.SetActive (false);
				isCountDown = false;


			}
		
		}

	}

	public void startCountDown(){

		isCountDown = true;
		TimeCost = 3.0f;
		CountDown.text = ""+(int)TimeCost;
		Color color = CountDown.color;
		color.a = 1.0f;
		CountDown.color = color;


	}

}
