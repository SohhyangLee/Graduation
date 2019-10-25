using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textmanager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textfile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public GameObject yes1;
	public GameObject yes2;

	//public PlayerController player;

	// Use this for initialization
	void Start () {

		yes1.SetActive (false);
		yes2.SetActive (false);

		if (textfile != null) {
			textLines = (textfile.text.Split ('\n'));

		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}

	}

	void Update(){
		theText.text = textLines [currentLine];

		if(Input.GetMouseButtonDown(0)){
			currentLine += 1;
			if(currentLine == endAtLine){
				yes1.SetActive (true);
				yes2.SetActive (true);
			}
		}
	}
}
