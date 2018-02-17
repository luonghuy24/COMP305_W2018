using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 10.0f;
	public float jumpForce = 300;
	public Transform groundCheck;
	public LayerMask definedGround;
	
	// Private variables
	private Rigidbody2D rBody;
	private SpriteRenderer sRend;
	private Animator animator;

	private bool isGrounded = false;
	private float groundRadius = 0.2f;

	void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
		sRend = this.GetComponent<SpriteRenderer>();
		animator = this.GetComponent<Animator>();
		animator.SetBool ("A", true);
	}

	void Update(){
		if (Input.GetAxis ("Jump") > 0 && isGrounded) {
			animator.SetBool ("Ground", isGrounded);
			rBody.AddForce (new Vector2(0, jumpForce));
		}
	}

	// Used for physics calculations
	void FixedUpdate () {

		isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, definedGround);

		//Debug.Log ("Grounded? " + isGrounded);

		animator.SetBool ("Ground", isGrounded);
		animator.SetFloat ("vSpeed", rBody.velocity.y);
		animator.SetBool ("A", true);

		float moveHoriz = Input.GetAxis("Horizontal");

		// Pass horizontal velocity to animator (SPEED)
		animator.SetFloat("Speed", Mathf.Abs(moveHoriz));
		animator.SetFloat("kSpeed", Mathf.Abs(moveHoriz));

		Debug.Log("Move Horizontal: " + moveHoriz);
		rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

		if(moveHoriz > 0)
		{
			sRend.flipX = false;
		} else if (moveHoriz < 0)
		{
			sRend.flipX = true;
		}
	}
}
