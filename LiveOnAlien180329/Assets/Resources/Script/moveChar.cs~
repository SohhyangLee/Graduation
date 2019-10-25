using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveChar : MonoBehaviour {
	public float speed = 0.0f;
	private Rigidbody2D m_Rigidbody2D;
	private Touch tempTouchs;
	private Vector2 touch;

	public GameObject player;
	private float _halfHeight;
	private float _halfWidth;

	// Use this for initialization
	void Start () {
		_halfHeight = Screen.height * 0.5f;
		_halfWidth = Screen.width * 0.5f;
	}

	// Update is called once per frame
	void Update () {
		#if UNITY_ANDROID
		speed = 0.1f;
		Vector3 viewPos = Camera.main.WorldToViewportPoint (player.transform.position);
		viewPos.x = Mathf.Clamp01 (viewPos.x);
		viewPos.y = Mathf.Clamp01 (viewPos.y);
		Vector3 worldPos = Camera.main.ViewportToWorldPoint (viewPos);
		player.transform.position = worldPos;

		if (Input.touchCount > 0) {
			for (int i = 0; i < Input.touchCount; i++) {
				if (EventSystem.current.IsPointerOverGameObject (i) == false) {
					tempTouchs = Input.GetTouch (i);
					if (tempTouchs.phase == TouchPhase.Began) {
						touch = Input.GetTouch (0).position;
						float _deltaPosX = touch.x - _halfWidth;
						float _deltaPosY = touch.y - _halfHeight;
						float _Xpos = _deltaPosX - transform.localPosition.x;
						float _Ypos = _deltaPosY - transform.localPosition.y;
						player.transform.Translate ((new Vector2 (_Xpos,_Ypos))*Time.deltaTime*speed);
					}
				}

			}
		}
		#endif

		#if UNITY_EDITOR
		speed = 5.0f;
		float keyHorizontal = Input.GetAxis("Horizontal");
		float keyVertical = Input.GetAxis("Vertical");

		player.transform.Translate(Vector3.right*speed*Time.smoothDeltaTime*keyHorizontal, Space.World);
		player.transform.Translate(Vector3.up*speed*Time.smoothDeltaTime*keyVertical, Space.World);
		#endif



		/*
		 if (Input.touchCount > 0) {
			if(EventSystem.current.IsPointerOverGameObject() == false) {
				Vector2 touch = Input.GetTouch (0).position;
				float _deltaPosX = touch.x - _halfWidth;
				float _deltaPosY = touch.y - _halfHeight;
				float _Xpos = _deltaPosX - transform.localPosition.x;
				float _Ypos = _deltaPosY - transform.localPosition.y;
				player.transform.Translate ((new Vector2 (_Xpos,_Ypos))*Time.deltaTime*speed);//_deltaPosX,_deltaPosY
			}
		}
		 */

	}
}
