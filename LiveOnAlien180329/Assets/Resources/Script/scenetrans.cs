﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetrans : MonoBehaviour {

	public void SceneTrans_main() {
		SceneManager.LoadScene ("main");
	}

	public void SceneTrans_beach(){
		SceneManager.LoadScene ("beach");
	}

	public void SceneTrans_minigame(){
		SceneManager.LoadScene ("minigame");
	}

	public void SceneTrans_map(){//mapButton
		SceneManager.LoadScene ("map");
	}

	public void SceneTrans_volcano(){
		SceneManager.LoadScene ("maingame_hunting2");
	}

	public void SceneTrans_grassland(){
		SceneManager.LoadScene ("maingame_hunting1");
	}

	public void SceneTrans_room(){
		SceneManager.LoadScene ("home");
	}

	public void SceneTrans_start(){
		SceneManager.LoadScene ("start");
	}

	public void SceneTrans_restaurant(){
		SceneManager.LoadScene ("restaurant");
	}

	public void SceneTrans_recipe(){
		SceneManager.LoadScene ("recipe");
	}

	public void SceneTrans_maingame1(){
		SceneManager.LoadScene ("maingame1");
	}


}
