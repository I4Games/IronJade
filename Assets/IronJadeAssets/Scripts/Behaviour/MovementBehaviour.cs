using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {

	public float speed;
	public Rigidbody rigidBody;
	public Transform direction;
	SoundManager soundManager;

	void Start()
	{
		rigidBody = gameObject.GetComponent<Rigidbody> ();
		soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");

		if (moveVertical > 0)
		{
			soundManager.PlayPlayerMovementSound ();
			//Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
			rigidBody.velocity = direction.forward * speed;
		}

		if (moveVertical < 0)
		{
			soundManager.PlayPlayerMovementSound ();
			//Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
			rigidBody.velocity = -direction.forward * speed;
		}
	}
}
