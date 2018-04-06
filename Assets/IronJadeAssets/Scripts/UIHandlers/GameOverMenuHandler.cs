
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenuHandler : MonoBehaviour 
{

	public Button restartButton;
	public Button quitButton;
	public GameObject mainMenu;

	// Use this for initialization
	void Start () 
	{
		restartButton.onClick.AddListener (OnReStartButtonClicked);
		quitButton.onClick.AddListener (OnQuitButtonClicked);
	}

	public void OnReStartButtonClicked()
	{
		Debug.Log ("OnReStartButtonClicked");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

	}

	public void OnQuitButtonClicked()
	{
		Debug.Log ("OnQuitButtonClicked");
		Application.Quit ();
	}

}
