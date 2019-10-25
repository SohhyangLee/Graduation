using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeBackground : MonoBehaviour {

	public Sprite spr;
	private SpriteRenderer sr;
	public Sprite bg1;
	public Sprite bg2;
	public Sprite bg3;

	Vector2 myVector = new Vector2(Screen.width, Screen.height);

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void Apple(){
		maingameTest1 pp = GameObject.Find ("MainScript").GetComponent<maingameTest1> ();

		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = spr;
//		transform.GetComponent<RectTransform>().sizeDelta = myVector;

		if ((pp.buttoncount %3) == 1) {
			sr.sprite = bg1;
			Debug.Log ("bg1");
		} else if ((pp.buttoncount %3) == 2) {
			sr.sprite = bg2;
			Debug.Log ("bg2" );
		} else if ((pp.buttoncount %3) == 0) {
			sr.sprite = bg3;
			Debug.Log ("bg3" );
		} else {
		}

	}

}
