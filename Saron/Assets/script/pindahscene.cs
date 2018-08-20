using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pindahscene : MonoBehaviour {

	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	// Use this for initialization
	public void pindah (string scenename) {
		Application.LoadLevel (scenename);
	}

}
