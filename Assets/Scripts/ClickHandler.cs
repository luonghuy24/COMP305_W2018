using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

	public GameObject simple_humanoid;
	public int someNumber;
	public List<Sprite> newImage;

	private Rigidbody2D rBody;
	private SpriteRenderer sRender;

	void Start () {
		rBody = simple_humanoid.GetComponent<Rigidbody2D>();
		rBody.velocity = new Vector2 (5, 0);
		sRender = simple_humanoid.GetComponent<SpriteRenderer> ();
	}

	void Update () {
		
	}

	// Guarenteed to run at a specific interval
	// Physic (i.e.
	void FixedUpdate(){
	}		

	void OnMouseDown(){
		//GameObject gObject = GameObject.Find ("Simple_humanoid");
		sRender.sprite = newImage[0];
		rBody.velocity *= -1;
		Debug.Log (someNumber);
	}

}
