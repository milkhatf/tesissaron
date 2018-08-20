using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class atung : MonoBehaviour {
	public AudioSource sound;
	public Animator anim;
	//public Animation anima;
	bool active=false;
	GameObject notee;
	public string tagg;

	void Start () {
		sound = gameObject.GetComponent<AudioSource> ();
		anim = gameObject.GetComponent<Animator> ();
		//anima = gameObject.GetComponent<Animation> ();
		resetScore ();


	}

	// Update is called once per frame
	void Update () {

	}
		

	void OnMouseOver () {
		if (Input.GetMouseButtonDown(0) && active) {
			//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && active) {
			Destroy (notee);
			AddScore ();
			active = false;
		}

		if (Input.GetMouseButtonDown (0)) {
			//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			sound.Play ();
			anim.SetBool ("sentuh", true);
			//anima.Play ("aset");

		} else {
			anim.SetBool ("sentuh", false);
		}
	}

	void OnTriggerEnter (Collider col){
		active = true;
		//Debug.Log ("aktif");
		//Debug.Log (col.gameObject.tag);
		//Debug.Log (tagg);
		if (col.gameObject.tag == tagg){
			notee = col.gameObject;
			//Destroy (notee);
			Debug.Log ("aktif");
			//Destroy (notee);
			//DestroyObject (notee);
			//Debug.Log (tagg);

		}
	}

	void AddScore (){
		PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + 10);
		//Debug.Log ("tambah");
	}

	void resetScore()
	{
		PlayerPrefs.SetInt ("Score", 0);
	}

	void OnTriggerExit (Collider col){
		active = false;
	}

}
