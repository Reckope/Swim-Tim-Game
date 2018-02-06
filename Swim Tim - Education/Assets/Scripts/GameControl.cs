using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject GameOver;
	public GameObject Menu;
	public Text scoreText;
	public Text gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -6.5f;

	private int score = 0;


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

		//if (gameOver == true && Input.GetMouseButtonDown (0)) {
		//	SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		//}
		
	}

	public void TimDied() {

		gameOverText.text = "Final Score: " + score.ToString ();
		scoreText.text = null;
		GameOver.SetActive (true);
		Menu.SetActive (true);
		gameOver = true;
	}

	public void TimScored(){

		if (gameOver == true) {
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();

	}
}
