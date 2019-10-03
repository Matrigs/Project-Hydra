using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5f;

	public Rigidbody2D playerRB;
	public Animator playerAnim;

	Vector2 movement;

    // Update is called once per frame
    void Update() {
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		playerAnim.SetFloat("Horizontal", movement.x);
		playerAnim.SetFloat("Vertical", movement.y);
		playerAnim.SetFloat("Speed", movement.sqrMagnitude);
	}

	void FixedUpdate() {
		playerRB.MovePosition(playerRB.position + movement * moveSpeed * Time.fixedDeltaTime);
	}
}
