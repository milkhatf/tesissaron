using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	public void doquit () {
		Debug.Log ("keluar game");
		//Application.Quit;
		Application.Quit();
	}
}
