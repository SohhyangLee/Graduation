using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
	public static ItemDatabase instance;
	public List<Item> items = new List<Item> ();

	void Awake(){
		instance = this;
	}
	// Use this for initialization
	void Start () {

		//ingredient
		Add ("Gold", 1, "Precious", ItemType.Ingredient);
		Add ("Sulfur", 1, "Atomic number 16", ItemType.Ingredient);
		Add ("Bread", 1, "Fresh Apple", ItemType.Ingredient);
		Add ("CherryBlossom", 1, "Pretty", ItemType.Ingredient);
		Add ("Tarte", 1, "Cheese flavour", ItemType.Ingredient);
		Add ("Pi", 1, "THAT Pi", ItemType.Ingredient);
		Add ("Apple", 1, "Fresh Apple", ItemType.Ingredient);
		//dish
		Add("GoldenBread", 1, "Good for alien", ItemType.Dish);
		Add("CherryBlossomTarte", 1, "Pretty but awful taste", ItemType.Dish);
		Add("ApplePie", 1, "Who made this?", ItemType.Dish);
		//fish
		Add("Dorumuk", 1, "It looks like rotten...", ItemType.Fish);
		Add ("Rainbowtrout", 1, "PERFECT", ItemType.Fish);
		Add ("Squid", 1, "Alien likes it", ItemType.Fish);
		Add ("Flounder", 1, "GAZAMI", ItemType.Fish);
	}

	void Add (string itemName, int itemValue, string itemDesc, ItemType itemType){
		items.Add (new Item (itemName, itemValue, itemDesc, itemType, 0, Resources.Load<Sprite> ("ItemImages/" + itemName)));
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector2 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Ray2D ray = new Ray2D (wp, Vector2.zero);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction);

			if(hit.collider.tag == "apple"){
				Debug.Log ("아이템을 찾았습니다.");
				Destroy(hit.collider.gameObject);
			}

			if(hit.collider.tag == "pi"){
				Debug.Log ("아이템을 찾았습니다.");
				Destroy(hit.collider.gameObject);

			}


		}
	
}
}
