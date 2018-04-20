using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public Transform bulletSpawn2;
	public GameObject mainMenu;

	public GameObject gun1;
	public GameObject gun2;

	public float bulletSpeed = 80f;

	private SoundManager soundManager;
	private Transform currentBulletSpawn;

	private int currentGunIndex = 0;

	public bool canSwitchWeapons = false;

	// Use this for initialization
	void Start () {
		soundManager = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
		currentBulletSpawn = bulletSpawn;
		gun2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!mainMenu.activeSelf && Input.GetButtonDown ("Fire1")) 
		{
			Fire ();
		}

		if (!mainMenu.activeSelf && (Input.GetButtonDown ("Fire3") || Input.GetKeyDown(KeyCode.E)) && canSwitchWeapons) 
		{
			SwitchGuns ();
		}
	}

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			currentBulletSpawn.position,
			currentBulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;


		// Destroy the bullet after 2 seconds
		Destroy(bullet, 3.0f);
		soundManager.PlayShootSound ();
	}

	void SwitchGuns()
	{
		if (currentGunIndex == 0) {
			currentGunIndex = 1;
			gun1.SetActive (false);
			gun2.SetActive (true);
			currentBulletSpawn = bulletSpawn2;
		} 
		else {
			currentGunIndex = 0;
			gun2.SetActive (false);
			gun1.SetActive (true);
			currentBulletSpawn = bulletSpawn2;
		}
	}
}
