using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType{
	Ingredient,
	Dish,
	Fish
}
	
[System.Serializable]
public class Item {
	public string itemName;
	public int itemValue;//갯수
	public string itemDesc;
	public ItemType itemType;
	public int itemCount;
	public Sprite itemImage;

	public Item(string _itemName, int _itemValue, string _itemDesc, ItemType _itemType, int _itemCount, Sprite _itemImage) {
		itemName = _itemName;
		itemValue = _itemValue;
		itemDesc = _itemDesc;
		itemType = _itemType;
		itemCount = _itemCount;
		itemImage = _itemImage;
	}
		

}
