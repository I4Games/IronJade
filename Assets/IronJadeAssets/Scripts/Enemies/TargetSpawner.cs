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
    /// The detection radius
    /// </summary>
    public float detectionRadius = 1.0f;

    /// <summary>
    /// The spawn radius
    /// </summary>
    public float spawnRadius = 1.0f;

    /// <summary>
    /// The transform of the player
    /// </summary>
    private Transform playerTransform;
    private SphereCollider sphere;
    private bool detected = false;

    /// <summary>
    /// Initialization
    /// </summary>
	void Start () {
        sphere = GetComponent<SphereCollider>();
        sphere.radius = detectionRadius;
	}

    /// <summary>
    /// Detect collision
    /// </summary>
    /// <param name="other">The collider of the other object</param>
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player") && !detected){
            playerTransform = other.transform;
            detected = true;
            InvokeRepeating("Spawn", spawnRate, spawnRate);
        }
    }

    /// <summary>
    /// Detect when the player exits the spawner radius
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other){
        if(other.transform == playerTransform && detected){
            playerTransform = null;
            detected = false;
            CancelInvoke();
        }
    }

    /// <summary>
    /// Spawn a target from the list
    /// </summary>
    private void Spawn(){
        if(playerTransform == null){
            return;
        }

        int idx = Random.Range(0, targetPrefabs.Count);
		Target obj = Instantiate(targetPrefabs[idx], transform) as Target;

        float xPos = Random.Range(playerTransform.position.x - spawnRadius, playerTransform.position.x + spawnRadius);
        float zPos = Random.Range(playerTransform.position.z - spawnRadius, playerTransform.position.z + spawnRadius);
        obj.transform.position = new Vector3(xPos, transform.position.y, zPos);
    }
}
