using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class acce : MonoBehaviour {
	//public GameObject obj;
	public AudioSource sound;
	protected bool active=false;
	protected GameObject note;
	float accelerometerUpdateInterval = 1.0f / 60.0f;
	float lowPassKernelWidthInSeconds = 2.0f;
	float shakeDetectionThreshold = 2.0f;
	float lowPassFilterFactor;
	Vector3 lowPassValue;
	public Animation anim;
	public Animator anima;

	void Start () {
		sound = gameObject.GetComponent<AudioSource> ();
		//anim = gameObject.GetComponent<Animation> ();
		anima = gameObject.GetComponent<Animator> ();
		resetScore ();
		lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
		shakeDetectionThreshold *= shakeDetectionThreshold;
		lowPassValue = Input.acceleration;
		//anima.SetBool ("goyang", false);

	}

	// Update is called once per frame
	void Update () {
		Vector3 acceleration = Input.acceleration;
		lowPassValue = Vector3.Lerp (lowPassValue, acceleration, lowPassFilterFactor);
		Vector3 deltaAcceleration = acceleration - lowPassValue;
		//anima.SetBool ("goyang", true);
		if (deltaAcceleration.sqrMagnitude >= shakeDetectionThreshold) {
			sound.Play ();
			anima.SetBool ("goyang", true);
			//anim.Play ();
			//anima.enabled=true;
			//anima.Play ("angklunggerak");
		} else {
			anima.SetBool ("goyang", false);
		}

		if (Input.GetMouseButtonDown (0)) {
			//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			sound.Play ();
			anima.SetBool ("goyang", true);
			//anima.Play ("aset");

		} else {
			anima.SetBool ("goyang", false);
		}
	}

//	void OnMouseOver () {
//		if (Input.GetMouseButtonDown (0)) {
//			//sound.Play ();
//			anima.SetBool ("goyang", true);
//			Debug.Log ("skooor");
//		} else {
//			anima.SetBool ("goyang", false);
//		}
//	}

	protected void AddScore (){
		PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + 10);

	}

	protected void resetScore()
	{
		PlayerPrefs.SetInt ("Score", 0);
	}



}
