using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour {

	public GameObject huy;
	public List<Sprite> newImage;
	private SpriteRenderer sRender;

	// Use this for initialization
	void Start () {
		sRender = huy.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){		
		switch (this.name) {
			case "blue-btn":
				sRender.sprite = newImage[0];
				break;
			case "red-btn":
				sRender.sprite = newImage[1];
				break;
			case "yellow-btn":
				sRender.sprite = newImage[2];
				break;
		}
	}
}
