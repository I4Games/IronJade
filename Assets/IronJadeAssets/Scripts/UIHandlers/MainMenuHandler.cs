using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour 
{

	public Button startButton;
	public Button tutorialButton;
	public Button quitButton;
	public Button creditButton;

	// Use this for initialization
	void Start () 
	{
		startButton.onClick.AddListener (OnStartButtonClicked);
		tutorialButton.onClick.AddListener (OnTutorialButtonClicked);
		quitButton.onClick.AddListener (OnQuitButtonClicked);
		creditButton.onClick.AddListener (OnCreditButtonClicked);
	}

	public void OnStartButtonClicked()
	{
		Debug.Log ("OnStartButtonClicked");
		gameObject.SetActive(false);

	}

	public void OnTutorialButtonClicked()
	{
		Debug.Log ("OnTutorialButtonClicked");
	}

	public void OnQuitButtonClicked()
	{
		Debug.Log ("OnQuitButtonClicked");
		Application.Quit ();
	}

	public void OnCreditButtonClicked()
	{
		Debug.Log ("OnCreditButtonClicked");
		Application.Quit ();
	}
}
