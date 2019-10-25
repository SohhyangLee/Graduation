using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {
	public Animation ModelAnimation;

	public void PlayAnimation(string animationName) {
		ModelAnimation.CrossFade (animationName, 0.3f);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
