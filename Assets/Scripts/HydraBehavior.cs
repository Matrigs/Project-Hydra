using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class HydraBehavior : MonoBehaviour
{
	public AIPath aiPath;
	public Animator hydraAnim;
	public List<SpawnPoint> spawnHydras;

	void Start() {
		hydraAnim.SetFloat("Speed", 1);
	}

	void Update() {
		if (aiPath.desiredVelocity.x != 0f) {
			hydraAnim.SetFloat("Horizontal", aiPath.velocity.x);
		}

		if (aiPath.desiredVelocity.y != 0f) {
			hydraAnim.SetFloat("Vertical", aiPath.velocity.y);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Bullet") {

			for (int i = 0; i < spawnHydras.Count; i++) {
				spawnHydras[i].HydraDeath();
			}
		}
	}
}
