using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 10f;
	public float turningSpeed = 100f;
	Animator anim;
	// Vector3 movement;
	// Rigidbody playerRigidbody;
	// float rotY;

	void Awake() 
	{
		anim = GetComponent <Animator> ();
		// playerRigidbody = GetComponent <Rigidbody> ();

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		// float h = Input.GetAxis ("Horizontal");
		// float v = Input.GetAxis ("Vertical");
		float h = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        
         
        float v = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

		//Move
		Move (h, v);

		Animating (h, v);
	}

	void Animating (float h, float v)
	{
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = h != 0f || v != 0f;

		// Tell the animator whether or not the player is walking.
		anim.SetBool ("IsWalking", walking);
	}

	void Move(float h, float v) 
	{
		// movement.Set(h, 0f, v);
//		rotY += rotate * rotationSpeed * Time.deltaTime;
//		transform.rotation = Quaternion.Euler (0f, rotY, 0f);
		// Vector3 movement = new Vector3(h, 0f, v) * moveSpeed * Time.deltaTime;
		// transform.Translate(movement, Space.Self);
//		playerRigidbody.MovePosition(transform.position + movement);
//		playerRigidbody.MoveRotation(transform.rotation);
		transform.Rotate(0, h, 0);
		transform.Translate(0, 0, v);

	}
		
}
