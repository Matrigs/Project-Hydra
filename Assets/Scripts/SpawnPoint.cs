using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	public Transform spawnPoint;
	public GameObject enemyPrefab;
	IEnumerator coroutine;

	public void Respawn () {
		GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
		coroutine = WaitTime();
		StartCoroutine(coroutine);
	}

	IEnumerator WaitTime () {
		yield return new WaitForSeconds(1);
	}
}
