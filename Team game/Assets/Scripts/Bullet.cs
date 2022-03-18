using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float spd = 20f;
	public int damage = 40;
	public Rigidbody2D rb;

	// Update is called once per frame
	void Update()
	{
		rb.velocity = transform.right * spd;
	}
	void OnTriggerEnter2D(Collider2D hitInfo)
	{



		Destroy(gameObject);

	}
}
