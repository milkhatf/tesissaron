using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tung : MonoBehaviour {
	public AudioSource sound;
	public Animator anim;
	bool active=false;
	GameObject note;


	void Start () {
		sound = gameObject.GetComponent<AudioSource> ();
		anim = gameObject.GetComponent<Animator> ();
		resetScore ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && active) {
		//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && active) {
			Destroy (note);
			AddScore ();
			active = false;
		}
	}

	void OnMouseOver () {
		if (Input.GetMouseButtonDown(0)) {
		//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			sound.Play ();
			anim.SetBool ("sentuh", true);
		} else {
			anim.SetBool ("sentuh", false);
		}
	}

	void OnTriggerEnter (Collider col){
		active = true;
		if (col.gameObject.tag == "note"){
			note = col.gameObject;
		}
	}

	void AddScore (){
		PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + 10);
	}

	void resetScore()
	{
		PlayerPrefs.SetInt ("Score", 0);
	}

	void OnTriggerExit (Collider col){
		active = false;
	}

}
