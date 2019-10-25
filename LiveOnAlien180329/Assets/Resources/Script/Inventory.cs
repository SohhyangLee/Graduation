using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	public static Inventory instance;
	public GameObject invenPanel;
	public Transform slot;
	public List<Slot> slotScripts = new List<Slot> ();

	void Awake() {
		Debug.Log ("HEY");
		instance = this;
		invenPanel.SetActive (false);
		SlotMake (2, 3, 0.04f);



		}

	// Use this for initialization
	void Start () {
		Debug.Log ("START");
		AddItem (6, 1);
		AddItem (5, 1);
	}
		

	void Update () {

	}

	public void AddItem (int number, int itemCount) {
		Debug.Log ("ADDITEM");
		int sameItemSlotNumber = -1;
		if (ItemDatabase.instance.items [number].itemType != ItemType.Dish) {
			for (int i = 0; i < slotScripts.Count; i++) {
				if (slotScripts [i].item.itemName == ItemDatabase.instance.items [number].itemName && slotScripts [i].item.itemCount < 99) {
					sameItemSlotNumber = i;
					break;
				}
			}
		}

		if (sameItemSlotNumber == -1) {
			Debug.Log ("IF 1");
			for (int i = 0; i < slotScripts.Count; i++) {
				if (slotScripts [i].item.itemValue == 0) {
					Debug.Log ("IF IF");
					slotScripts [i].item = ItemDatabase.instance.items [number];
					ItemImageChange (slotScripts [i]);
					Debug.Log ("slocripts");
					Debug.Log (slotScripts[i].item);
					break;
				}
			}
		} else {
			Debug.Log ("IF 2");
			Item item = ItemDatabase.instance.items [number];
			item.itemCount += itemCount;
			slotScripts [sameItemSlotNumber].item = item;
			ItemImageChange (slotScripts [sameItemSlotNumber]);
		}

	}

	void SlotMake (int xCount, int yCount, float xInterval) {
		Vector2 panelSize = new Vector2(GetComponent<RectTransform>().rect.width, GetComponent<RectTransform>().rect.height);
		float xWidthRate = (1 - xInterval * (xCount + 1)) / xCount;
		float yWidthRate = panelSize.x * xWidthRate / panelSize.y;
		float yInterval = (1 - yWidthRate * yCount) / (yCount + 1);
		for (int y = 0; y < yCount; y++) {
			for (int x = 0; x < xCount; x++) {
				Transform newSlot = Instantiate(slot);
				newSlot.name = "Slot" + (y + 1) + "." + (x + 1);
				newSlot.parent = transform;
				RectTransform slotRect = newSlot.GetComponent<RectTransform>();
				slotRect.anchorMin = new Vector2(xWidthRate * x + xInterval * (x + 1), 1 - (yWidthRate * (y + 1) + yInterval * (y + 1)));
				slotRect.anchorMax = new Vector2(xWidthRate * (x + 1) + xInterval * (x + 1), 1 - (yWidthRate * y + yInterval * (y + 1)));
				slotRect.offsetMin = Vector2.zero;
				slotRect.offsetMax = Vector2.zero;

				slotScripts.Add(newSlot.GetComponent<Slot>());
				newSlot.GetComponent<Slot>().number = y * xCount + x;

			}
		}
	}

	public void ItemImageChange(Slot _slot) {
		if (_slot.item.itemValue == 0) {
			_slot.transform.GetChild (0).gameObject.SetActive (false);
		} else {
			_slot.transform.GetChild (0).gameObject.SetActive (true);
			_slot.transform.GetChild (0).GetComponent<Image> ().sprite = _slot.item.itemImage;
			if (_slot.item.itemType != ItemType.Dish) {
				_slot.transform.GetChild (0).GetChild (0).gameObject.SetActive (true);
			} else {
				_slot.transform.GetChild (0).GetChild (0).gameObject.SetActive (false);
				_slot.transform.GetChild (0).GetChild (0).GetChild (0).GetComponent<Text> ().text = "" + _slot.item.itemCount;
			}
		}
	}



}
