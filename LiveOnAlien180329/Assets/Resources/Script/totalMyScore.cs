﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalMyScore : MonoBehaviour {
	public Text score;
	int c1, c2;
	static int result;
	static public int num;

	public Sprite spr;
	private SpriteRenderer sr;
	public Sprite perfect;
	public Sprite great;
	public Sprite ap;
	public Sprite garbage;

	public GameObject other;//DO NOT REMOVE
	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
	//	score.text = "count : " + c1 + "+"+c2;

	}

	public void myScore(){
	//	maingameTest1 pp1 = GameObject.Find ("MainScript").GetComponent<maingameTest1> ();

//		sr = gameObject.GetComponent<SpriteRenderer> ();
//		sr.sprite = spr;
		CharacterMove cm = other.GetComponent<CharacterMove>();//to change rep value

		maingameTest2 pp2 = GameObject.Find ("MainScript").GetComponent<maingameTest2> ();

		c1 = maingameTest1.result1;
		c2 = pp2.buttoncount;

		result =c1+c2;

		if (result > 60) {
	//		sr.sprite = perfect;
			num=1;
			score.text = string.Format ("I made a Perfect apple pie!!!");
			cm.rep += 5;//in game, rep += 5*6
			Debug.Log ("Perfect");
		} else if (result <= 60 && result > 53) {
	//		sr.sprite = great;
			num=2;
			score.text = string.Format ("I made a Great apple pie!");
			cm.rep += 3;
			Debug.Log ("Great");
		} else if (result <= 53 && result > 45) {
	//		sr.sprite = ap;
			num=3;
			score.text = string.Format ("I made an Apple Pie.");
			cm.rep += 1;
			Debug.Log ("Good");
		} else {
	//		sr.sprite = garbage;
			num=4;
			score.text = string.Format ("I made an apple pie like garbage...");
			cm.rep -= 1;
			Debug.Log ("Bad");
		}
		cm.levelsystem ();
		cm.sceneSave ();
	}

}
