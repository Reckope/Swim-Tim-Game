using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {	

	public string startGameScene;

	public void StartGame ()
	{
		Application.LoadLevel (startGameScene);
	}

	public void Rules ()
	{
		Application.LoadLevel (startGameScene);
	}

}

