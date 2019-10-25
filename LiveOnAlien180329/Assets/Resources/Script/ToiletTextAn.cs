using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ToiletTextAn : MonoBehaviour {

	public Text activePanel;
	public GameObject YButton;
	public GameObject NButton;
	public GameObject ToiletPanel;
	public GameObject closeButton;

	void Awake () {
		activePanel.text = "깨끗한 물이 흐르는 화장실이다. 씻겠습니까?";

	}

	// Update is called once per frame
	void Update () {
		
	}

	public void YesButton(){
		Debug.Log ("Click Yes Button");
		activePanel.text = "기분은 좋아졌지만 아무 일도 일어나지 않았다.";
		NButton.SetActive (false);
		YButton.SetActive (false);
		closeButton.SetActive (true);

	}

	public void exitButton(){
		Debug.Log("Click Close Button");
		ToiletPanel.SetActive (false);
	}

	public void NoButton(){
		Debug.Log ("Click No Button");
		ToiletPanel.SetActive (false);
	}
}

