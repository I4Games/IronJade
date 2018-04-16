using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
		ammoLeft = ammoPerRound;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (uiHandler != null && !uiHandler.mainMenuCanvas.activeSelf) {

			timeLeft -= Time.deltaTime;
			uiHandler.updateTimeLeftHUDWith((int) timeLeft);

			if (numberOfTargetsLeft <= 0) {

				if (SceneManager.GetActiveScene ().name == "FirstPlayable") {
					SceneManager.LoadScene ("Lv2");
				}
				else if (SceneManager.GetActiveScene ().name == "Lv2") {
					SceneManager.LoadScene ("Lv3");
				}
				else if (SceneManager.GetActiveScene ().name == "Lv3") {
					uiHandler.showWinConditionCanvas ();
				}

			}

			if (timeLeft < 0 || ammoLeft <= 0) {
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
