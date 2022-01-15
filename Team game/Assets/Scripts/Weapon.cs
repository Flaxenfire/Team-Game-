using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;
	public Transform bombPoint;
	public GameObject bombtPrefab;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			Shoot ();
		}
		if (Input.GetButtonDown("Fire2")){
			Shoot1 ();
		}
	}
	void Shoot()
	{
		Instantiate (bulletPrefab, firePoint.position, firePoint.rotation);
	}
	void Shoot1()
	{
		Instantiate (bombtPrefab, bombPoint.position, bombPoint.rotation);
	}
}
