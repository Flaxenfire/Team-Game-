using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public GameObject bombPrefab;
	public gameStart turnManager;
	public GameObject meleePrefab;
	//public int round;
	public Text RoundText;

	// Update is called once per frame
	void Update()
	{
		if (turnManager.player1attack)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				Shoot();
				turnManager.player1attack = false;
				turnManager.player2turn = true;
				roundPlusNumber();
			}
			else if (Input.GetButtonDown("Fire2"))
			{
				Shoot1();
				turnManager.player1attack = false;
				turnManager.player2turn = true;
				roundPlusNumber();
			}
			else if (Input.GetButtonDown("Fire4"))
			{
				Shoot2();
				turnManager.player1attack = false;
				turnManager.player2turn = true;
				roundPlusNumber();
			}
		}
	}
	void Shoot()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
	void Shoot1()
	{
		Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
	}
	void Shoot2()
	{
		Instantiate(meleePrefab, firePoint.position, firePoint.rotation);
	}

	//2022.02.20:let round number plus and rewrite the number on the scene
    public void roundPlusNumber()
    {
		//round++;
		//RoundText.text = round.ToString();
		scoreBoard.round += 1;//read the variable round from scoreBoard.cs
		RoundText.text = scoreBoard.round.ToString();//read the variable round from scoreBoard.cs
	}
}
