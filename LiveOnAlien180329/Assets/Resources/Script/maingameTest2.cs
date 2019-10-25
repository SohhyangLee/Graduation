using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class maingameTest2 : MonoBehaviour {

	public GameObject button;
	public GameObject resultPanel;


	public int buttoncount=0;
	static public int result2=0;

	public Text Count;
	public float TimeCost = 8.0f;

	// Use this for initialization
	void Start () {
		resultPanel.SetActive (false);

	}

	// Update is called once per frame
	void Update () {
			TimeCost -= Time.deltaTime;
	//		Count.text = "";
			if (TimeCost < 0) {
				result2 = buttoncount;
				button.SetActive (false);
				if (TimeCost < -2) {
		//			Count.text = "";
		//			isCountDown = false;
					resultPanel.SetActive (true);
		//			Count.text = "count : " + buttoncount + "+"+c1;
				}
			}
	}

	public void LeftIncresing(){

		buttoncount++;

	}



}
