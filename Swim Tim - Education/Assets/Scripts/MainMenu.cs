using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(AudioSource))]
public class MainMenu : MonoBehaviour {	

	public string startGameScene;
	public string rulesScene;
	public string backToMenuScene;

	//public AudioSource MainMenumusic;

	void Start () {

		//MainMenumusic.Play ();

	}

	public void StartGame ()
	{
		Application.LoadLevel(this.startGameScene);
	}

	public void Rules ()
	{
		Application.LoadLevel(this.rulesScene);
	}

	public void backToMenu ()
	{
		Application.LoadLevel(this.backToMenuScene);
	}

}

