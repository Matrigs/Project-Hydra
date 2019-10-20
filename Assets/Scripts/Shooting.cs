using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject wand;
	public GameObject bulletPrefab;

	IEnumerator coroutine;
	public bool shotFired = false;

	public float bulletForce = 20f;

    // Update is called once per frame
    void Update() {
		if (shotFired == false) {
			if (Input.GetButtonDown("Fire1")) {
				Shoot();
			}
		}
    }

	void Shoot () {
		wand.SetActive(false);
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
		bulletRB.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

		//Iniciar cooldown do ataque
		shotFired = true;
		coroutine = Cooldown();
		StartCoroutine (coroutine);
	}

	IEnumerator Cooldown () {
		//Depois do cooldown, respawna a orbe
		yield return new WaitForSeconds(3);
		wand.SetActive(true);
		shotFired = false;
	}
}
