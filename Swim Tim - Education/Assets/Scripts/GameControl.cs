using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject GameOver;
	public bool gameOver = false;
	public float scrollSpeed = -6.5f;


	// Use this for initialization
	void Awake () {

		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		
	}

	public void TimDied() {

		GameOver.SetActive (true);
		gameOver = true;
	}
}
