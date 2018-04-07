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
    /// Determines if the bird is dead
    /// </summary>
    protected bool dead = false;

	/// <summary>
    /// Initialization of private variables
    /// </summary>
	public override void Start () {
		base.Start ();
        Invoke("Die", despawnTime);
        float yAngle = Random.Range(-90f, 90f);
        float xAngle = Random.Range(-90f, 0f);
        dir = Vector3.forward;
		transform.Rotate(new Vector3(xAngle, yAngle, 0f));
	}
	
	/// <summary>
    /// Update movement
    /// </summary>
	void Update () {
        if (dead) {
            DeathBehaviour();
        }else {
            Behave();
        }
	}

    public virtual void Behave(){
        transform.Translate(dir * speed * Time.deltaTime);
    }

    public virtual void SetDeathState(){
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }

    public virtual void DeathBehaviour(){
        transform.Translate(dir * speed * Time.deltaTime);
    }

    /// <summary>
    /// Implementation of parent GetShot
    /// </summary>
    public override void GetShot(){
        CancelInvoke();
        SetDeathState();
        Invoke("Die", 3f);
		soundManager.PlayBirdDeathSound ();
		gameManager.TargetKilled ();
    }

    /// <summary>
    /// Kill this bird
    /// </summary>
    void Die(){
        Destroy(gameObject);
    }
}
