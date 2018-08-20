using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class benar : MonoBehaviour, IPointerEnterHandler {

	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
////		if (Input.GetMouseButtonDown (0)) {
////			//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && active) {
////			AddScore ();
////			Debug.Log ("tambah");
////		}
//	}
//
	public void OnPointerEnter (PointerEventData eventData) {
		Debug.Log ("tambahh");
		AddScore ();
		if (Input.GetMouseButtonDown(0) ) {
			//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && active) {
			AddScore ();
			Debug.Log ("tambah");

		}
			
	}

//	void OnMouseExit (){
//		Debug.Log ("kurang");
//	}

	void AddScore (){
		PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + 25);
		//Debug.Log ("tambah");
	}
		
}
