using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3Controller : MonoBehaviour {

	public Transform playerPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (playerPosition.position.x, this.transform.position.y, this.transform.position.z);
	}
}
