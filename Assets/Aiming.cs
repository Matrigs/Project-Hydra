using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
	public PlayerMovement playerMovement;

	Vector2 mousePos;
	public Rigidbody2D wandRB;
	public Camera cam;

	void Update() {

		//aiming
		mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
		playerMovement.movement.x = Input.GetAxisRaw("Horizontal");
		playerMovement.movement.y = Input.GetAxisRaw("Vertical");
	}

	void FixedUpdate() {
		wandRB.MovePosition(wandRB.position + playerMovement.movement * playerMovement.moveSpeed * Time.fixedDeltaTime);

		Vector2 lookDir = mousePos - wandRB.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
		wandRB.rotation = angle;
	}
}
