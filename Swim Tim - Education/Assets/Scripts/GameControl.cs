using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;

	public GameObject GameOver;
	public GameObject Menu;
	public GameObject QuestionTime;

	public Text scoreText;
	public Text gameOverText;
	public Text timerText;

	public Text questionText;
	public Text firstChoiceText;
	public Text secondChoiceText;
	public Text thirdChoiceText;
	public Text fourthChoiceText;
	public Text correctText;

	public bool gameOver = false;
	public bool questionTime = false;

	public float scrollSpeed = -6.5f;
	public float tunaSpeed;
	public float enemySpeed;
	//public float enemySpeed;

	private float timer = 7.0f;
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

		if(questionTime == true){

			timer -= Time.deltaTime;
			timerText.text = timer.ToString ("N0");

			if (timer < 0.0f) {

				timerText.text = "0";
				QuestionTime.SetActive (false);
				TimDied ();
			}

			//if (Input.GetMouseButtonDown (0)) { 	// TEST FOR QUESTION					

			//	questionTime = false;
			//	QuestionTime.SetActive (false);
			//	timer = 7.0f;

			//}
		}
		
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

		if(score % 2 == 0){

			DisplayQuestion ();
			
		}

	}

	public void DisplayQuestion() {

		questionTime = true;
		QuestionTime.SetActive (true);

	}

	public void completeQuestion() {
		
		questionTime = false;
		QuestionTime.SetActive (false);
		timer = 7.0f;
		QuestionsControl.randomQuestion = -1;
		StartCoroutine (displayCorrect ());

	}

	public IEnumerator displayCorrect () {

		correctText.text = "CORRECT";
		yield return new WaitForSeconds (1);
		correctText.text = " ";

	}
}
