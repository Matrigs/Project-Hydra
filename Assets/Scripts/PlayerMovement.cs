using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5f;

	public Rigidbody2D playerRB;
	public Animator playerAnim;
	public Camera cam;

	Vector2 movement;
	Vector2 mousePos;

    // Update is called once per frame
    void Update() {
		//walking
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		playerAnim.SetFloat("Horizontal", movement.x);
		playerAnim.SetFloat("Vertical", movement.y);
		playerAnim.SetFloat("Speed", movement.sqrMagnitude);

		//aiming
		mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
	}

	void FixedUpdate() {
		playerRB.MovePosition(playerRB.position + movement * moveSpeed * Time.fixedDeltaTime);

		Vector2 lookDir = mousePos - playerRB.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
		playerRB.rotation = angle;
	}
}
