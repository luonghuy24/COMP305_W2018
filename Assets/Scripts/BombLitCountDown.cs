using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLitCountDown : MonoBehaviour {

	public GameObject explosion;

	void Start () {
		Invoke ("Explode", 1);
	}

	void Explode () {
		// Create explosion at this point
		Instantiate(explosion, this.transform.position, this.transform.rotation);
		Destroy (this.gameObject);
		Debug.Log("Boooommm");
	}
}
