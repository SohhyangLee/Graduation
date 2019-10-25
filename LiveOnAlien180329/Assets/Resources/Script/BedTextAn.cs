using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class BedTextAn : MonoBehaviour {


	public Text activePanel;
	public Text activeButton;
	public GameObject BedPanel;
	public GameObject NButton;
	public GameObject YButton;
	public GameObject closeButton;


	void Awake () {
		activePanel.text = "포근한 내 침대다. 누우시겠습니까?";

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void YesButton(){
		Debug.Log ("Click Yes Button");
		activePanel.text = "체력이 모두 회복되었습니다.";
		NButton.SetActive (false);
		YButton.SetActive (false);
		closeButton.SetActive (true);
	}

	public void exitButton(){
		Debug.Log("Click Close Button");
		BedPanel.SetActive (false);
	}

	public void NoButton(){
		Debug.Log ("Click No Button");
		BedPanel.SetActive (false);
	}
}
