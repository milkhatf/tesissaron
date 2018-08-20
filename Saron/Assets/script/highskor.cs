using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highskor : MonoBehaviour {

	//public string name;
	int skorr;
	//int highscore;
	// Use this for initialization
	void Start (){
		GetComponent<Text> ().text = PlayerPrefs.GetInt ("HighScore", 0).ToString();
	}
	// Update is called once per frame
	void Update () {
		skorr = PlayerPrefs.GetInt ("Score");
		if (PlayerPrefs.GetInt ("HighScore", 0) < skorr) {
			PlayerPrefs.SetInt ("HighScore", skorr);
			GetComponent<Text> ().text = skorr.ToString();
			//highscore = skorr;
			//Debug.Log (highscore);
		}

	}

	public void Reset(){
		PlayerPrefs.DeleteAll();
		GetComponent<Text> ().text = "0";
	}
}
