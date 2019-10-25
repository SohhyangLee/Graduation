using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotomap : MonoBehaviour {

	public void SceneChangeMap(){
		SceneManager.LoadScene ("map");
	}
}
