using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract class for objects that can be shot
/// </summary>
public abstract class Target : MonoBehaviour {
	protected GameManager gameManager;
    /// <summary>
    /// Callback for when the object gets shot
    /// </summary>
    public abstract void GetShot();
	protected SoundManager soundManager;

	public virtual void Start ()
	{
		gameManager = GameObject.Find ("GameManager").gameObject.GetComponent<GameManager>();
		soundManager = GameObject.Find ("SoundManager").GetComponent<SoundManager>();
	}
}
