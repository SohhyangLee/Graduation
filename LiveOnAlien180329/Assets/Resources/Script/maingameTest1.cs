using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class maingameTest1 : MonoBehaviour {

	public GameObject button;
//	public GameObject nextbutton;

	public int buttoncount=0;
	static public int result1 = 0;

	public Text Count;
	public float TimeCost = 8.0f;
	bool isCountDown = true;

	// Use this for initialization
	void Start () {
	//	nextbutton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (isCountDown) {
			TimeCost -= Time.deltaTime;
			Count.text = "";

			if (TimeCost < 0) {
			//	Count.text = "count : " + buttoncount + " result : win!";
				result1 = buttoncount;
				Count.text = "Next... ";
				button.SetActive (false);
				if (TimeCost < -3) {
					
					Count.text = "";
			//		nextbutton.SetActive (true);
					isCountDown = false;
					SceneManager.LoadScene ("maingame2");
			//		nextbutton.SetActive (true);
				}
			}

		}

	}

	public void LeftIncresing(){
		
		buttoncount++;

	}

	public void nextGame1(){
		SceneManager.LoadScene ("maingame2");
	}

	public void gotoRestaurant(){
		SceneManager.LoadScene ("restaurant");
		
	}
}
