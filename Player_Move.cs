using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	public int PlayerSpeed = 10; //Player's speed
	public int PlayerJumpPower = 100; // Player's jumping power
	public float moveX;
	public bool isGrounded;

	// Update is called once per frame
	void Update()
	{
		PlayerMove();
	}

	void PlayerMove()
	{
		//Controls
		moveX = Input.GetAxis("Horizontal");
		if(Input.GetButtonDown("Jump") && isGrounded == true)
		{
			Jump();
		}
		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump()
	{
		//Jumping code
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * PlayerJumpPower);
		isGrounded = false;

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
	}
}
