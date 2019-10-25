using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImage : MonoBehaviour {

	public Sprite spr;
	private SpriteRenderer sr;
	public Sprite Rainbowtrout;
	public Sprite Flounder;
	public Sprite Squid;
	public Sprite Dorumuk;

	public Text itemName;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}


	public void whatIsMyPresent(){
		pingpong pp = GameObject.Find ("movingbar").GetComponent<pingpong> ();

	//	sr = gameObject.GetComponent<SpriteRenderer> ();
	//	sr.sprite = spr;


		if (pp.score == 0) {
	//		sr.sprite = Rainbowtrout;
			itemName.text = string.Format ("I got a Rainbowtrout!");
			Debug.Log ("Rainbowtrout");
		} else if (pp.score == 1) {
	//		sr.sprite = Flounder;
			itemName.text = string.Format ("I got a Flounder!");
			Debug.Log ("Flounder" );
		} else if (pp.score == 2) {
	//		sr.sprite = Squid;
			itemName.text = string.Format ("I got a Squid!");
			Debug.Log ("Squid" );
		} else if (pp.score == 3) {
	//		sr.sprite = Dorumuk;
			itemName.text = string.Format ("I got a Dorumuk!");
			Debug.Log ("Dorumuk");
		} else {
			itemName.text = string.Format ("I missed it!");
		}
	
	}

}
