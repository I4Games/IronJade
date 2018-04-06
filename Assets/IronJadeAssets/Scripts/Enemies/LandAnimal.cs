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
            transform.Translate(movementDir * speed * Time.deltaTime);
        }
    }

    /// <summary>
    /// Callback from getting shot
    /// </summary>
    public override void GetShot(){
        dead = true;
    }
}
