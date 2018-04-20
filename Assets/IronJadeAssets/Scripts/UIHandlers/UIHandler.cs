using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

	public GameObject gameOverCanvas;
	public GameObject winConditionCanvas;
	public GameObject mainMenuCanvas;
	public GameObject hudCanvas;

	public Text targetsLeftText;
	public Text timeLeftText;
	public Text ammoLeftText;
	public Text gameCanvasScore;

	SoundManager soundManager;

	void Start(){
		soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
	}

	public void updateTargetsLeftHUDWith(int newValue){
	
		targetsLeftText.text = newValue.ToString ();

	}

	public void updateTimeLeftHUDWith(int newValue){
	
		timeLeftText.text = newValue.ToString ();

	}

	public void updateAmmoLeftHUDWith(int newValue){
	
		ammoLeftText.text = newValue.ToString ();
	
	}

	public void updateGameOverScore(int newValue){
	
		if (gameCanvasScore != null) {
			gameCanvasScore.text = newValue.ToString ();
		}

	}

	public void showGameOverCanvas() {

		soundManager.PlayGameOverSound ();
		winConditionCanvas.SetActive (false);
		mainMenuCanvas.SetActive (false);
		gameOverCanvas.SetActive (true);
		hudCanvas.SetActive(false);

	}

	public void showWinConditionCanvas() {

		soundManager.PlayGameWonSound ();
		winConditionCanvas.SetActive (true);
		mainMenuCanvas.SetActive (false);
		gameOverCanvas.SetActive (false);
		hudCanvas.SetActive(false);

	}

	public void showMainMenuCanvas(){
		
		mainMenuCanvas.SetActive (true);
		gameOverCanvas.SetActive (false);
		winConditionCanvas.SetActive (false);
		hudCanvas.SetActive(false);

	}

	public void hideAllMenus(){
	
		mainMenuCanvas.SetActive (false);
		gameOverCanvas.SetActive (false);
		winConditionCanvas.SetActive (false);
		hudCanvas.SetActive(false);
	
	}

	public void ShowHudCanvas(){
		
		mainMenuCanvas.SetActive (false);
		gameOverCanvas.SetActive (false);
		winConditionCanvas.SetActive (false);
		hudCanvas.SetActive(true);

	}
}
