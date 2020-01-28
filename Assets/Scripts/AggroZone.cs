using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AggroZone : MonoBehaviour {

	public GameObject hydraPrefab;
	public Transform playerPrefab;
	public AIDestinationSetter aIDestination;

	void Start() {
		aIDestination = hydraPrefab.GetComponent<AIDestinationSetter>();
		aIDestination.target = null;
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			Debug.Log("Oh? You're approaching me?");
			aIDestination.target = playerPrefab;
		}
	}

	void OnTriggerExit2D(Collider2D collision) {
		if (collision.CompareTag("Player")) {
			Debug.Log("Oh? Running away?");
			StartCoroutine("AggroCountdown");
		}
	}

	IEnumerator AggroCountdown () {
		yield return new WaitForSeconds(1);
		Debug.Log("Waiting...");
		StartCoroutine("EndAggro");
	}

	IEnumerator EndAggro () {
		aIDestination.target = null;
		Debug.Log("Not interested anymore.");
		yield return null;
	}
}