using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to test the effects of shooting a target
/// </summary>
public class ShotAfterSeconds : MonoBehaviour {

    /// <summary>
    /// The target to shoot
    /// </summary>
    public Target target;
    /// <summary>
    /// The amount of time in seconds to wait before shooting the target
    /// </summary>
    public float seconds = 1f;

	/// <summary>
    /// Call the delayed target shooting on start
    /// </summary>
	void Start () {
        Invoke("ShootTarget", seconds);
	}

    /// <summary>
    /// Shoots the target
    /// </summary>
    void ShootTarget(){
        target.GetShot();
    }
}
