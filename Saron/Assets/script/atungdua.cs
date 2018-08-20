using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atungdua : MonoBehaviour {
	public AudioSource sound;
	protected bool active=false;
	protected GameObject note;
	public Animator anima;

	void Start () {
		sound = gameObject.GetComponent<AudioSource> ();
		anima = gameObject.GetComponent<Animator> ();
		resetScore ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver () {
		if (Input.GetMouseButtonDown(0)){
			sound.Play ();
			anima.SetBool ("goyang", true);
			//anima.Play ("aset");

		} else {
			anima.SetBool ("goyang", false);
		}
	}

	protected void AddScore (){
		PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + 10);
		Debug.Log ("skooor");
	}

	protected void resetScore()
	{
		PlayerPrefs.SetInt ("Score", 0);
	}



}
