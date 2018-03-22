using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Bird enemy
/// </summary>
public class Bird : Target {

    /// <summary>
    /// Bird's movement speed
    /// </summary>
    public float speed = 2f;

    /// <summary>
    /// Current vertical direction of flight
    /// </summary>
    private float dir;

	/// <summary>
    /// Initialization of private variables
    /// </summary>
	void Start () {
        dir = 1f;
	}
	
	/// <summary>
    /// Update movement
    /// </summary>
	void FixedUpdate () {
        transform.Translate(Vector3.up * speed * dir * Time.fixedDeltaTime);
	}

    /// <summary>
    /// Implementation of parent GetShot
    /// </summary>
    public override void GetShot(){
        dir = -1f;
    }
}
