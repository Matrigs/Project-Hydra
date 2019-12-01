using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
	public PlayerMovement playerMovement;

	//public Rigidbody2D orbRB;
	//public Camera cam;
	//Vector3 mousePos;

	public Transform target;
	public float fRadius = 3.0f;
	private Transform pivot;

	void Start() {
		pivot = new GameObject().transform;
		transform.parent = pivot;
	}

	void Update() {
		//aiming
		Vector3 v3Pos = Camera.main.WorldToScreenPoint(target.position);
		v3Pos = Input.mousePosition - v3Pos;
		float angle = Mathf.Atan2(v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;

		//rotating the orb around the character as a pivot
		pivot.position = target.position;
		pivot.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
