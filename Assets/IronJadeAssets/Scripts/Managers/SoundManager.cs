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
	private AudioSource hippoMoveSound;

	[SerializeField]
	private AudioSource hippoDeathSound;

	[SerializeField]
	private AudioSource playerMovementSound;

	[SerializeField]
	private AudioSource levelOverSound;

	[SerializeField]
	private AudioSource gameWonSound;

	[SerializeField]
	private AudioSource gameOverSound;

	[SerializeField]
	private AudioSource timerCloseToEndSound;

	void Start(){
		if (playerMovementSound != null) {
			playerMovementSound.loop = true;
		}
	}

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

	public void PlayHippoDeathSound(){
		if (hippoDeathSound != null) {
			hippoDeathSound.Play ();
		}
	}

	public void PlayHippoMoveSound(){
		if (hippoMoveSound != null) {
			hippoMoveSound.Play ();
		}
	}

	public void PlayPlayerMovementSound(){
		if (playerMovementSound != null) {
			if (!playerMovementSound.isPlaying) {
				playerMovementSound.Play ();
			}
		}
	}

	public void PausePlayerMovementSound(){
		if (playerMovementSound != null) {
			if (playerMovementSound.isPlaying) {
				playerMovementSound.Pause ();
			}
		}
	}

	public void PlayLevelOverSound(){
		if (levelOverSound != null) {
			levelOverSound.Play ();
		}
	}

	public void PlayGameWonSound(){
		if (gameWonSound != null) {
			gameWonSound.Play ();
		}
	}

	public void PlayGameOverSound(){
		if (gameOverSound != null) {
			gameOverSound.Play ();
		}
	}

	public void PlayTimerCloseToEndSound(){
		if (timerCloseToEndSound != null) {
			timerCloseToEndSound.Play ();
		}
	}
}
