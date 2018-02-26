using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

	public float maxSpeed = 10f;
	public float jumpForce = 80;
	public Transform groundCheck;
	public LayerMask definedGround;

	private Rigidbody2D rBody;
	private SpriteRenderer sRend;
	private Animator animator;

	private bool isGrounded = false;
	private float groundRadius = 0.2f;

	void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
		sRend = this.GetComponent<SpriteRenderer>();
		animator = this.GetComponent<Animator>();
	}

	void Update(){
		if (Input.GetAxis ("P1_Jump") > 0 && isGrounded) {
			animator.SetBool ("Ground", isGrounded);
			rBody.AddForce (new Vector2(0, jumpForce));
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, definedGround);

		animator.SetBool ("Ground", isGrounded);
		animator.SetFloat ("vSpeed", rBody.velocity.y);

		float moveHoriz = Input.GetAxis("P1_Horizontal");

		rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

		animator.SetFloat("Speed", Mathf.Abs(moveHoriz));

		if (moveHoriz > 0) {
			sRend.flipX = false;
		} else if (moveHoriz < 0) {
			sRend.flipX = true;	
		}
	}
}
