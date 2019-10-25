using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UIdate : MonoBehaviour {
	public Text dateText;
	public float TimeRatio = 0.01f;
	public float GameTime = 0; 
	private int year = 2018;
	private int month = 1;
	private int days = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameTime += Time.deltaTime / TimeRatio;
		dateText.text = ToString ();
	}
	public override string ToString() {
		return string.Format ("{0:00}:{1:00}", Hours, Minutes);
		//return string.Format ("{0:0000}-{1:00}-{2:00} {3:00}:{4:00}", Year, Month, Days, Hours, Minutes);
	}
	/*
	int Milliseconds {
		get {
			return (int)((GameTime - TotalSeconds) * 1000);
		}
	}
	int Seconds {
		get {
			return TotalSeconds % 60;
		}
	}
	*/
	int Minutes { 
		get {
			return TotalSeconds / 60 % 60;
		}
	}
	int Hours {
		get {
			return TotalSeconds / (60 * 60) % 60 % 24;
		}
	}
	int Days {
		get {
			return days;
		}
		set {
			days = TotalSeconds / (60 * 60 * 24);
		}
	}
	int Month {
		get {
			return month;
		}
		set {
			month = TotalSeconds / (30 * 24 * 60 * 60);
		}
	}
	int Year { 
		get {
			return year;
		}
		set {
			year = TotalSeconds / (365 * 24 * 60 * 60);
		}
	}
	int TotalSeconds {
		get {
			return (int)GameTime;
		}
	}
}
