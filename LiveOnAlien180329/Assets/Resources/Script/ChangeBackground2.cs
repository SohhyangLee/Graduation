using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground2 : MonoBehaviour {

	public Sprite spr;
	private SpriteRenderer sr;
	public Sprite bg1;
	public Sprite bg2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void Apple(){
		maingameTest2 pp = GameObject.Find ("MainScript").GetComponent<maingameTest2> ();

		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = spr;
		//		transform.GetComponent<RectTransform>().sizeDelta = myVector;

		if ((pp.buttoncount %2) == 1) {
			sr.sprite = bg1;
			Debug.Log ("bg1");
		} else if ((pp.buttoncount %2) == 0) {
			sr.sprite = bg2;
			Debug.Log ("bg2" );
		} else {
		}

	}

}
