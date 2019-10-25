using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialImage : MonoBehaviour {
	public GameObject itemImage;

	void Awake() {
		itemImage.SetActive (false);
	}

	public void imageSetActive() {
		itemImage.SetActive (true);
	}
}
