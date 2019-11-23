using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movementScript;
	public Aiming aimScript;
	public Shooting shootScript;

	void OnCollisionEnter2D(Collision2D collisionInfo) {
		if (collisionInfo.collider.tag == "Enemy") {
			movementScript.enabled = false;
			aimScript.enabled = false;
			shootScript.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
