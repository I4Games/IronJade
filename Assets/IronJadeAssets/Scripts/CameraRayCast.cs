using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRayCast : MonoBehaviour 
{

	public float cursorRange = 50f; 
	public GameObject mainMenu;
	public GameObject gameOverMenu;
	public Transform crossHairPosition;

	private Camera fpsCam;

	void Start()
	{
		fpsCam = gameObject.GetComponent<Camera> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire2")) 
		{
			mainMenu.SetActive (true);
		}

		Vector3 rayOrigin = crossHairPosition.TransformDirection (Vector3.forward);

		Debug.Log (rayOrigin.ToString());

//		Debug.DrawRay(crossHairPosition.position, rayOrigin * 50, Color.red);
		RaycastHit hit;
		if (Physics.Raycast (crossHairPosition.position, rayOrigin, out hit, cursorRange)) 
		{
			if (hit.collider.gameObject.tag == "uibutton"
			    && Input.GetButtonDown ("Fire1")) {
				HandleButtonClicked (hit.collider.gameObject.GetComponentInChildren<Text> ().text);
			} 
			else if (hit.collider.gameObject.tag == "enemy" 
					&& Input.GetButtonDown ("Fire1")
					&& !mainMenu.activeSelf) 
			{
				Destroy (hit.collider.gameObject,0.1f);
			}
		}
	}

	void HandleButtonClicked(string buttonName)
	{
		MainMenuHandler mainMenuHandler = mainMenu.GetComponent<MainMenuHandler>();
		GameMenuHandler gameOverMenuHandler = gameOverMenu.GetComponent<GameMenuHandler>();
		switch (buttonName) 
		{
		case "Start":
			mainMenuHandler.OnStartButtonClicked ();
			break;
		case "Tutorial":
			mainMenuHandler.OnTutorialButtonClicked ();
			break;
		case "Quit":
			if (mainMenu.activeSelf) {
				mainMenuHandler.OnQuitButtonClicked ();
			} 
			else if (gameOverMenu.activeSelf) {
				gameOverMenuHandler.OnQuitButtonClicked ();
			}
			break;
		case "Restart":
			gameOverMenuHandler.OnReStartButtonClicked ();
			break;
		}
	}
}
