using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns targets
/// </summary>
public class TargetSpawner : MonoBehaviour {

    /// <summary>
    /// The potential targets to spawn
    /// </summary>
    public List<Target> targetPrefabs;

    /// <summary>
    /// The spawnrate in seconds
    /// </summary>
    public float spawnRate;

    /// <summary>
    /// Initialization
    /// </summary>
	void Start () {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
	}

    /// <summary>
    /// Spawn a target from the list
    /// </summary>
    private void Spawn(){
        int idx = Random.Range(0, targetPrefabs.Count);
        Instantiate(targetPrefabs[idx], transform);
    }
}
