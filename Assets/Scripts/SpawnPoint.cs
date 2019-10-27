using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	public Transform spawnPoint;
	public GameObject enemyPrefab;
	public float respawnDelay = 5f;

	//GameObject hydraModel;

	IEnumerator coroutine;

	public void HydraDeath () {
		coroutine = WaitTime();
		StartCoroutine(coroutine);
		//transform.parent = null;
		//behaviorScript.KillHydra();
		Debug.Log("Enemy dead");
	}

	public IEnumerator WaitTime () {
		Debug.Log("Respawning...");
		yield return new WaitForSeconds(respawnDelay);
		Respawn();
	}

	public void Respawn () {
		GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
		enemyPrefab = newEnemy;
		Debug.Log("Respawned");
		Destroy(gameObject);
	}

	public void OnDestroy() {
		Destroy(transform.parent.gameObject);
	}
}
