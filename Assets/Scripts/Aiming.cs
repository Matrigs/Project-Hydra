using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
	public PlayerMovement playerMovement;

	public Rigidbody2D orbRB;
	public Camera cam;
	Vector3 mousePos;

	void Update() {
		//aiming
		mousePos = cam.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z));
		orbRB.transform.position = playerMovement.playerRB.position;

	}
	
	void FixedUpdate() {
		//this makes the orb rotate
		Vector3 lookDir = mousePos - orbRB.transform.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
		orbRB.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
	}
}
