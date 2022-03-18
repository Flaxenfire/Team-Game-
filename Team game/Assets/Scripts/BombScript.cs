using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

	public float sped = 4f;
	public Vector3 LaunchOffset;
	public bool Thrown;

	void Start()
	{
		if (Thrown)
		{
			var direction = transform.right + Vector3.up;
			GetComponent<Rigidbody2D>().AddForce(direction * sped, ForceMode2D.Impulse);
		}
		transform.Translate(LaunchOffset);
	}

	void Update()
	{
		if (!Thrown)
		{
			transform.position += transform.right * sped * Time.deltaTime;
		}
	}



	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		if (hitInfo.gameObject.layer == 3)
		{
			DestroyObject(gameObject);
		}




	}


}