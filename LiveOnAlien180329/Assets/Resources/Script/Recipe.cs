using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour {

	public GameObject recipeList;

	bool status = false;


	void Start(){
		recipeList.SetActive (false);

	}

	public void showRecipe(){
		status = !status;
		if (status) {
			recipeList.SetActive (true);
		} else {
			recipeList.SetActive (false);
		}
	}


	/*public void showContent(){
      breadContent.SetActive (true);
   }*/
}