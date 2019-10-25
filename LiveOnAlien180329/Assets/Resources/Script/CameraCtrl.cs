using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {

	public GameObject A;
	Transform AT;
	void Start () {
		AT = A.transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (AT.position.x, AT.position.y, transform.position.z);
	}
}
