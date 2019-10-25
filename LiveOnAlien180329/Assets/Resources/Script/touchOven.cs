using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchOven : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Raycasthit 2D
		if (Input.GetMouseButtonDown (0)) {
			Vector2 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Ray2D ray = new Ray2D (wp, Vector2.zero);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);

			if (hit.collider.tag == "oven") {
				Debug.Log ("성공적으로 화덕을 찾았습니다.");
				SceneManager.LoadScene ("recipe");

			}
		
		}
	}
}
