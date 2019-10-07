using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraBehavior : MonoBehaviour
{
	public List<SpawnPoint> spawnHydras;

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Bullet") {

			for (int i = 0; i < spawnHydras.Count; i++) {
				spawnHydras[i].Respawn();
			}
			Destroy(gameObject);
		}
	}
}
