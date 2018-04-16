using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Land animal target
/// </summary>
public class LandAnimal : Target {

    /// <summary>
    /// Movement speed
    /// </summary>
    public float speed = 2f;

    /// <summary>
    /// The player's transform
    /// </summary>
    Transform playerTransform;

    /// <summary>
    /// Determines if this animal is dead
    /// </summary>
    bool dead = false;

    /// <summary>
    /// Initialization
    /// </summary>
    public override void Start(){
        base.Start();
        playerTransform = GameObject.Find("Player").transform;
    }

    /// <summary>
    /// Update the movement of this object
    /// </summary>
    void Update(){
        if (!dead && playerTransform != null){
            Vector3 movementDir = (transform.position - playerTransform.position).normalized;
            movementDir.Set(movementDir.x, 0f, movementDir.z);
            transform.rotation = Quaternion.LookRotation(movementDir, Vector3.up);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    /// <summary>
    /// Callback from getting shot
    /// </summary>
    public override void GetShot(){
        if (!dead){
            dead = true;
            transform.Rotate(new Vector3(0f, 0f, 90f));
            soundManager.PlayLandAnimalDeathSound();
            Invoke("Die", 3f);
            gameManager.TargetKilled();
        }
    }

    /// <summary>
    /// Kill this animal
    /// </summary>
    void Die()
    {
        Destroy(gameObject);
    }
}
