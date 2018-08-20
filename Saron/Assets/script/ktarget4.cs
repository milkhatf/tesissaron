using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ktarget4 : ktung {
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && active) {
			//if (Input.mousePosition.x > 300 && Input.mousePosition.x <350 && Input.mousePosition.y <150) {
			if (Input.mousePosition.x < 1000 && Input.mousePosition.x >850 && Input.mousePosition.y <400 && Input.mousePosition.y >120) {
				Debug.Log ("bisa");
				AddScore ();
				Destroy (note);
				active = false;
				Debug.Log (active);
			}
		}

	}

	void OnTriggerEnter2D (Collider2D col){
		active = true;
		Debug.Log ("aktif");
		if (col.gameObject.tag == "note"){
			note = col.gameObject;
			Debug.Log (active);
		}

	}

	void OnTriggerExit2D (Collider2D col){
		active = false;

	}

}