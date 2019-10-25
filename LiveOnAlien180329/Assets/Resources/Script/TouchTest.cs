using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {

	public GameObject ToiletPanel;
	public GameObject BedPanel;
	public GameObject FirePanel;

	void Awake(){
		ToiletPanel.SetActive (false);
		BedPanel.SetActive (false);
	}

	void FixedUpdate()
	{
		//Raycasthit 2D
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Ray2D ray = new Ray2D (wp, Vector2.zero);
			RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

			if (hit.collider.tag == "pond") {
				Debug.Log ("성공적으로 연못을 찾았습니다.");
				ToiletPanel.SetActive (true);
			} else if (hit.collider.tag == "bed") {
				Debug.Log ("성공적으로 침대를 찾았습니다.");
				BedPanel.SetActive (true);
			} else if (hit.collider.tag == "kitchen")
				Debug.Log ("성공적으로 부엌을 찾았습니다.");
			else if (hit.collider.tag == "fire") {
				Debug.Log ("성공적으로 화로를 찾았습니다.");
				FirePanel.SetActive (true);
			}
			else
				Debug.Log ("실패했습니다.");

		}
}

}