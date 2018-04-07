using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	[SerializeField]
	private AudioSource shootSound;

	[SerializeField]
	private AudioSource birdDeathSound;

	[SerializeField]
	private AudioSource bushOrTreeSound;

	[SerializeField]
	private AudioSource birdFlyNearbySound;

	[SerializeField]
	private AudioSource landAnimalDeathSound;

	public void PlayShootSound(){
		if (shootSound != null) {
			shootSound.Play ();
		}
	}

	public void PlayBirdDeathSound(){
		if (birdDeathSound != null) {
			birdDeathSound.Play ();
		}
	}

	public void PlayBushOrTreeSound(){
		if (bushOrTreeSound != null) {
			bushOrTreeSound.Play ();
		}
	}

	public void PlayBirdFlyNearbySound(){
		if (birdFlyNearbySound != null) {
			birdFlyNearbySound.Play ();
		}
	}

	public void PlayLandAnimalDeathSound(){
		if (landAnimalDeathSound != null) {
			landAnimalDeathSound.Play ();
		}
	}
}
