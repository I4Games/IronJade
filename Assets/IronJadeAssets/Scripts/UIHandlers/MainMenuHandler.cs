using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour 
{

	public Button startButton;
	public Button tutorialButton;
	public Button quitButton;

	// Use this for initialization
	void Start () 
	{
		startButton.onClick.AddListener (OnStartButtonClicked);
		tutorialButton.onClick.AddListener (OnTutorialButtonClicked);
		quitButton.onClick.AddListener (OnQuitButtonClicked);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Joystick8Button2)) 
		{
			gameObject.SetActive (!gameObject.activeSelf);
		}
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
}
