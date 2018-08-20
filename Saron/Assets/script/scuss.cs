using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scuss : MonoBehaviour {

	//[RequireComponent(typeof(AudioSource))]
	public AudioSource lagu;
	public float volumenya;
	// Use this for initialization
	void Start () {
		lagu.Play ();
		lagu.volume = volumenya;
	}

	// Update is called once per frame
	void Update () {
		//lagu.volume = 0.0f;
	}
}
