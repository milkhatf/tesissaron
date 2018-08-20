using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atarget : acce {
	float accelerometerUpdateInterval = 1.0f / 60.0f;
	float lowPassKernelWidthInSeconds = 2.0f;
	float shakeDetectionThreshold = 2.0f;
	float lowPassFilterFactor;
	Vector3 lowPassValue;
	//public Animation anim;
	//public Animator anima;
	// Use this for initialization
	void Start () {
		sound = gameObject.GetComponent<AudioSource> ();
		//anim = gameObject.GetComponent<Animation> ();
		anima = gameObject.GetComponent<Animator> ();
		//resetScore ();
		lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
		shakeDetectionThreshold *= shakeDetectionThreshold;
		lowPassValue = Input.acceleration;
	}

	// Update is called once per frame
	void Update () {
		Vector3 acceleration = Input.acceleration;
		lowPassValue = Vector3.Lerp (lowPassValue, acceleration, lowPassFilterFactor);
		Vector3 deltaAcceleration = acceleration - lowPassValue;
		//anima.SetBool ("goyang", true);

		if (Input.GetMouseButtonDown (0) && active) {
			//if (Input.mousePosition.x > 100) {
			//if (Input.mousePosition.x < 300 && Input.mousePosition.x >50 && Input.mousePosition.y <400 && Input.mousePosition.y >100) {
				Debug.Log ("bisaas");
				AddScore ();
				Destroy (note);
				active = false;
				Debug.Log (active);
			//}
		}
		else if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold && active) {
			//sound.Play ();
			//anima.SetBool ("goyang", true);
			//anim.Play ();
			//anima.enabled=true;
			//anima.Play ("angklunggerak");
			Debug.Log ("bisa2");
			AddScore ();
			Destroy (note);
			active = false;
			Debug.Log (active);
		// else {
			//anima.SetBool ("goyang", false);
		}

	}

	void OnTriggerEnter (Collider col){
		active = true;
		Debug.Log ("aktif");
		if (col.gameObject.tag == "note"){
			note = col.gameObject;
			Debug.Log (active);
		}

	}

	void OnTriggerExit (Collider col){
		active = false;

	}

}