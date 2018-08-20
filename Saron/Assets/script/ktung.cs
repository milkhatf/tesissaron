using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ktung : MonoBehaviour {
	public AudioSource sound;
	public Animator anim;
	protected bool active=false;
	protected GameObject note;

	void Start () {
		sound = gameObject.GetComponent<AudioSource> ();
		anim = gameObject.GetComponent<Animator> ();
		resetScore ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver () {
		if (Input.GetMouseButtonDown(0)){
			sound.Play ();
			anim.SetBool ("sentuh", true);
		} else {
			anim.SetBool ("sentuh", false);
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
