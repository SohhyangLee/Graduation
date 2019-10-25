using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pingpong : MonoBehaviour {

	public GameObject bar;
	public GameObject confirmPanel;
	public int score = 0;

	// 주석처리된 코드는 테스트중이던 코드!



	int a = 1; // 방향전환용
	int b = 0;
	int speed=25; // 바의 속도
	int count = 0; // 미니게임 횟수제한용
	int RandomSpeed;


	bool _isPassed = false;
	float _t = 0f;


	Vector3 vector;
	Vector3 pos;

	string[] myArray = new string[4] {"Perfect", "great", "good", "bad"} ;


	void Awake() {
		confirmPanel.SetActive (false);
	}


	// Use this for initialization
	void Start () {

	//	Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true );

		vector.x = 0.57f;

		pos = bar.transform.position;


	}
	
	// Update is called once per frame
	void Update () {


		_t += Time.deltaTime;
		if (_t >= 3f && !_isPassed) {
		
			float fmove = Time.deltaTime * speed;


			if (bar.transform.localPosition.x <= -3.4f) 
			{ 
				a = -1; 
			} 
			else if(bar.transform.localPosition.x  >= 3.4f) 
			{ 
				a = 1; 
			} 

			bar.transform.Translate(Vector3.left * fmove * a ); 

			vector = bar.transform.position;
		
		
		}
	}


	public void stopBar(){


		if (b == 0) {
			speed = 0;
			b = 1;
			confirmPanel.SetActive (true);
		} else if (b == 1) {
			speed = 25;
			b = 0;
		}


		if (count >= 5) {
			speed = 0;
			count = 0;
			SceneManager.LoadScene ("beach");
		}
		count++;

	}

	public void confirmSetDisabled() {
		confirmPanel.SetActive (false);


	}



	public void movingbarReset() {
	//	vector.x = 0.57f;
		bar.transform.position = new Vector3 (0.0f, -1.5f, 0);
	}


	public void barPositon(){
		
		Debug.Log (vector.x);

		if (vector.x >= -0.12 && vector.x < 0.07) {
			Debug.Log ("" + myArray [0]);
			score = 0;
		} else if (vector.x >= -0.56 && vector.x < -0.12 || vector.x >= 0.07 && vector.x < 0.56) {
			Debug.Log ("" + myArray [1]);
			score = 1;
		} else if (vector.x >= -1.9 && vector.x < -0.56 || vector.x >= 0.56 && vector.x < 1.9) {
			Debug.Log ("" + myArray [2]);
			score = 2;
		} else if (vector.x >= -3.5 && vector.x < -1.9 || vector.x >= 1.9 && vector.x < 3.5) {
			Debug.Log ("" + myArray [3]);
			score = 3;
		} else {
			Debug.Log ("out!");
			score = 4;
		}


	
	}



}
