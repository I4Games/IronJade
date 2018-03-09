using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRayCast : MonoBehaviour 
{

	public float cursorRange = 50f; 
	public GameObject mainMenu;

	private Camera fpsCam;

	void Start()
	{
		fpsCam = gameObject.GetComponent<Camera> ();
	}

	// Update is called once per frame
	void Update () 
	{
		Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;
		if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, cursorRange)) 
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
		switch (buttonName) 
		{
		case "Start":
			mainMenuHandler.OnStartButtonClicked ();
			break;
		case "Tutorial":
			mainMenuHandler.OnTutorialButtonClicked ();
			break;
		case "Quit":
			mainMenuHandler.OnQuitButtonClicked ();
			break;
		}
	}
}
