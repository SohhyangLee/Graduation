using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class textBlink : MonoBehaviour {
	Text flashingText;
	Image flashingImage;
	public GameObject other;
	// Use this for initialization
	void Start () {
		flashingText = GetComponent<Text> ();
		flashingImage = other.GetComponent<Image> ();
		StartCoroutine (BlinkText ());
	}
	public IEnumerator BlinkText() {
		while (true) {
			flashingText.text = "";
			flashingImage.enabled = false;
			yield return new WaitForSeconds (.7f);
			flashingText.text = "TOUCH TO START";
			flashingImage.enabled = true;
			yield return new WaitForSeconds (.7f);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
