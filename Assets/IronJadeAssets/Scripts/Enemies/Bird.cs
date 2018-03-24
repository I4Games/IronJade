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
    /// Time it takes for the bird to disappear
    /// </summary>
    public float despawnTime = 10f;

    /// <summary>
    /// Current vertical direction of flight
    /// </summary>
    private Vector3 dir;

	/// <summary>
    /// Initialization of private variables
    /// </summary>
	void Start () {
        Invoke("Die", despawnTime);
        float zAngle = Random.Range(-90f, 90f);
        float xAngle = Random.Range(-90f, 90f);
        dir = Vector3.up;
        transform.Rotate(new Vector3(xAngle, 0f, zAngle));
	}
	
	/// <summary>
    /// Update movement
    /// </summary>
	void Update () {
        transform.Translate(dir * speed * Time.deltaTime);
	}

    /// <summary>
    /// Implementation of parent GetShot
    /// </summary>
    public override void GetShot(){
        CancelInvoke();
        transform.rotation = Quaternion.identity;
        dir = Vector3.down;
        Invoke("Die", 3f);
    }

    /// <summary>
    /// Kill this bird
    /// </summary>
    void Die(){
        Destroy(gameObject);
    }
}
