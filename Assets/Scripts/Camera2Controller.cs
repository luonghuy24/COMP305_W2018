using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Controller : MonoBehaviour {

	public Transform playerPosition;
	public Transform playerMoveThresholdLeft;
	public Transform playerMoveThresholdRight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerPosition.position.x > playerMoveThresholdRight.position.x) {
			this.transform.position = new Vector3 (playerPosition.position.x, this.transform.position.y, this.transform.position.z);
		} else if (playerPosition.position.x < playerMoveThresholdLeft.position.x) {
			this.transform.position = new Vector3 (playerPosition.position.x, this.transform.position.y, this.transform.position.z);
		}
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = Color.green;
		Gizmos.DrawLine (playerMoveThresholdLeft.position, new Vector3 (playerMoveThresholdLeft.position.x, playerMoveThresholdLeft.position.y + 10, playerMoveThresholdLeft.position.z));
		Gizmos.DrawLine (playerMoveThresholdRight.position, new Vector3 (playerMoveThresholdRight.position.x, playerMoveThresholdRight.position.y + 10, playerMoveThresholdRight.position.z));
	}
}
