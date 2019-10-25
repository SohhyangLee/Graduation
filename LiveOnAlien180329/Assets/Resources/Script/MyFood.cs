using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyFood : MonoBehaviour {
	int c1, c2;
	static int itemImage;

	public Sprite spr;
	private SpriteRenderer sr;
	public Sprite perfect;
	public Sprite great;
	public Sprite ap;
	public Sprite garbage;

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		//	score.text = "count : " + c1 + "+"+c2;

	}

	public void myScore(){
		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = spr;

		if (totalMyScore.num == 1) {
			sr.sprite = perfect;
		} else if (totalMyScore.num == 2) {
			sr.sprite = great;

		} else if (totalMyScore.num == 3) {
			sr.sprite = ap;
		} else {
			sr.sprite = garbage;
		}

	}

}
