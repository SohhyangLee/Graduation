using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;


public class changeImageTest : MonoBehaviour {

	public Sprite spr;
	private SpriteRenderer sr;
	public Sprite Rainbowtrout;
	public Sprite Flounder;
	public Sprite Squid;
	public Sprite Dorumuk;

	public Image image;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


	public void whatIsMyPresent(){
		pingpong pp = GameObject.Find ("movingbar").GetComponent<pingpong> ();

		sr = gameObject.GetComponent<SpriteRenderer> ();
		sr.sprite = spr;


		if (image != null) {

			if (pp.score == 0) {
	//			Sprite Rainbowtrout = Resources.Load<Sprite> ("Rainbowtrout");
	//			image.overrideSprite = Rainbowtrout;
				sr.sprite = Rainbowtrout;
				Debug.Log ("Rainbowtrout");
			} else if (pp.score == 1) {
	//			Sprite Flounder = Resources.Load<Sprite> ("Flounder");
	//			image.overrideSprite = Flounder;
				sr.sprite = Flounder;
				Debug.Log ("Flounder" );
			} else if (pp.score == 2) {
	//			Sprite Squid = Resources.Load<Sprite> ("Squid");
	//			image.overrideSprite = Squid;
				sr.sprite = Squid;
				Debug.Log ("Squid" );
			} else if (pp.score == 3) {
		//		Sprite Dorumuk = Resources.Load<Sprite> ("Dorumuk");
		//		image.overrideSprite = Dorumuk;
				sr.sprite = Dorumuk;
				Debug.Log ("Dorumuk");
			} else {
			}
		
		
		}

	}

}
