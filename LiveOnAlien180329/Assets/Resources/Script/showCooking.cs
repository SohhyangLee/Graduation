using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class showCooking : MonoBehaviour {

	public GameObject cookingPanel;
	public Text content;
	bool status;

	// Use this for initialization
	void Start () {
		cookingPanel.SetActive (false);
		content.text = "It is an applePi. Alien likes it.";
	}

	// Update is called once per frame
	public void showPanel () {
		status = !status;
		if (status) {
			cookingPanel.SetActive (true);
		} else {
			cookingPanel.SetActive (false);
		}
	}
}
