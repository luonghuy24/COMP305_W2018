using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Trigger : MonoBehaviour {

	public Camera mainCamera;
	public Camera camera2;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			camera2.enabled = true;
			mainCamera.enabled = false;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			mainCamera.enabled = true;
			camera2.enabled = false;
		}
	}

	void OnTriggerStay2D(Collider2D other){

	}
}
