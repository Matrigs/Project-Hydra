using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movementScript;

	void OnCollisionEnter2D(Collision2D collisionInfo) {
		if (collisionInfo.collider.tag == "Enemy") {
			movementScript.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
