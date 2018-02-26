using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUpCameraTrigger : MonoBehaviour {

	public Camera camera2;
	public Camera camera3;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			camera3.enabled = true;
			camera2.enabled = false;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			camera2.enabled = true;
			camera3.enabled = false;
		}
	}
}
