﻿                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     using System.Collections;using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
	public float speed;
	public float jumpHeight;
	public float fall;
	bool Onfloor = false;
	SpriteRenderer Player;
	Rigidbody2D rb;
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
		Player = GetComponent<SpriteRenderer> ();
}
	void Update(){
		rb.rotation = Quaternion.Euler (0f, 0f, 0f);
		//move
		float axisX = InputManager.MainHorizontal ();
		rb.AddForce (new Vector3 (axisX, 0) * Time.deltaTime * speed);
	
		if (axisX < 0) {
			Player.flipX = true;
		}
		if (axisX > 0) {
			Player.flipX = false;
		}
		if (InputManager.Abutton){
		if (Onfloor) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpHeight);
		}
	}
		if (rb.velocity.y > 0) {
			rb.velocity.y =(Vector2.up * Physics2D.gravity * fall * Time.deltaTime);
		
		}
	}
}