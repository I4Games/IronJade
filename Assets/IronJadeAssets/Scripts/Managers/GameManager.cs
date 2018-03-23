using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public float levelTimeOutInSeconds = 60;
	public int numberOfTargetsInLevel = 10;
	public int ammoPerRound = 20;
	public UIHandler uiHandler;

	private int numberOfTargetsLeft;
	private float timeLeft;
	private int ammoLeft;

	// Use this for initialization
	void Start () {
		numberOfTargetsLeft = numberOfTargetsInLevel;
		timeLeft = levelTimeOutInSeconds;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (uiHandler != null) {

			timeLeft -= Time.deltaTime;
			uiHandler.updateTimeLeftHUDWith((int) timeLeft);

			if (numberOfTargetsLeft <= 0) {
				uiHandler.showWinConditionCanvas ();
			}

			if (timeLeft < 0) {
				uiHandler.updateGameOverScore (numberOfTargetsInLevel - numberOfTargetsLeft);
				uiHandler.showGameOverCanvas();
				uiHandler.updateTimeLeftHUDWith(0);
			}

		}

	}

	public void TargetKilled() {
		numberOfTargetsLeft--;
		uiHandler.updateTargetsLeftHUDWith(numberOfTargetsLeft);
	}

	public void ShotFired(){
		ammoLeft--;
		uiHandler.updateAmmoLeftHUDWith (ammoLeft);
	}
		
}
