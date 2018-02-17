using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUnlidClickHandler : MonoBehaviour {

	public GameObject bombLit;

	void OnMouseDown(){

		Instantiate (bombLit, this.transform.position, this.transform.rotation);	
		Destroy (this.gameObject);
	}
}
