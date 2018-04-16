using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public GameObject mainMenu;
	public float bulletSpeed = 80f;

	private SoundManager soundManager;

	// Use this for initialization
	void Start () {
		soundManager = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!mainMenu.activeSelf && Input.GetButtonDown ("Fire1")) 
		{
			Fire ();
		}
	}

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;


		// Destroy the bullet after 2 seconds
		Destroy(bullet, 3.0f);
		soundManager.PlayShootSound ();
	}
}
