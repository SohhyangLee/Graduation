using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//적 머리 위에 hp바 표시하는 스크립트

public class UIhp : MonoBehaviour {
	public Slider enemySlider;
	public GameObject head;
	private CharacterAttribute attribute;

	// Use this for initialization
	void Start () {
		attribute = gameObject.GetComponent<CharacterAttribute> ();
	}
	
	// Update is called once per frame
	void Update () {
		enemySlider.value = (float)attribute.HP / (float)attribute.HPMAX;
		enemySlider.transform.position = head.transform.position;
	}
}
