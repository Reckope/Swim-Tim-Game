using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GameControl : MonoBehaviour {

	public static GameControl instance;

	public GameObject GameOver;
	public GameObject Menu;
	public GameObject QuestionTime;
	public GameObject CategoryTime;
	public GameObject QuestionBackground;

	public AudioSource BackgroundMusic;

	public Text scoreText;
	public Text gameOverText;
	public Text QuestionTimerText;
	public Text nextQuestionTimerText;
	public Text totalTimeText;
	public Text deathReasonText;

	public Text categoryTitleText;
	public Text category1Text;
	public Text category2Text;

	public Text questionText;
	public Text firstChoiceText;
	public Text secondChoiceText;
	public Text thirdChoiceText;
	public Text fourthChoiceText;
	public Text correctText;

	public bool gameOver = false;
	public bool questionTime = false;
	public int questionAnsweredCorrectly = 1;

	public bool categoryTime;
	public int selectedCategory;
	public bool choiceSelected = false; 

	public float scrollSpeed = -6.5f;
	public float tunaSpeed;
	public float enemySpeed;

	private float QuestionTimer = 12.0f;
	public static float nextQuestionTimer;

	public static int score = 0;
	public static float totalTime = 0f;
	public static int deathReason;
	public static int questionsAnwered = 0;

	// Use this for initialization
	void Awake () {

		BackgroundMusic.volume = 0.5f;
		nextQuestionTimer = 15f;
		questionsAnwered = 0;
		totalTime = 0f;
		score = 0;
		selectedCategory = 0;
		Tim.deadStatus = false;
		questionAnsweredCorrectly = 1;
		deathReason = 0;
		Application.targetFrameRate = 600;
		//QualitySettings.vSyncCount = 1;
		ChooseCategory ();

		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		
	}

	// Update is called once per frame
	void Update () {

		if (categoryTime == false) {
			StartNextQuestionTimer ();
			StartTotalTime ();

			if (questionTime == true) {

				BackgroundMusic.volume = 0.2f;
				StartQuestionTimer ();

				if (QuestionTimer < 0.0f) {

					QuestionTimerText.text = "0";
					QuestionTime.SetActive (false);
					deathReason = 4;
					TimDied ();
				}
			}
		}
		
	}

	public void TimDied() {

		BackgroundMusic.Stop ();
		SelectDeathReason ();
		Tim.deadStatus = true;
		QuestionTime.SetActive (false);
		QuestionBackground.SetActive (true);
		gameOverText.text = "Final Score: " + score.ToString ();
		DisplayTotalTime ();
		scoreText.text = null;
		GameOver.SetActive (true);
		Menu.SetActive (true);
		gameOver = true;
		Tim.ani.SetTrigger ("TimDead");

	}

	public void TimScored(){

		if (gameOver == true) {
			return;
		}
			
		score++;
		scoreText.text = "Score: " + score.ToString ();

	}

	public void DisplayQuestion() {

		questionTime = true;
		QuestionTime.SetActive (true);
		QuestionBackground.SetActive (true);

	}

	public void completeQuestion() {
		
		questionTime = false;
		questionAnsweredCorrectly = 2;
		QuestionTime.SetActive (false);
		QuestionBackground.SetActive (false);
		QuestionTimer = 12.0f;
		if (QuestionsControl.questionNumber < QuestionsControl.numberOfQuestions) {
			nextQuestionTimer = Random.Range (15f, 25f);
		} else {
			nextQuestionTimer = 1000000f;
		}
		nextQuestionTimerText.color = new Color (199.0f/255.0f, 0.0f/255.0f, 255.0f/255.0f);
		QuestionTimerText.color = Color.white;
		nextQuestionTimerText.fontSize = 17;
		CharacterHealth.currentHealth = 25f;
		QuestionsControl.randomQuestion = -1;
		questionsAnwered++;
		StartCoroutine (DisplayCorrectText ());
		BackgroundMusic.volume = 0.5f;
	}

	public void DeathBySquid(){

		questionTime = false;
		QuestionTime.SetActive (false);
		QuestionBackground.SetActive (false);
		QuestionTimer = 12.0f;
		nextQuestionTimer = Random.Range (15f, 25f);
		nextQuestionTimerText.color = new Color (199.0f/255.0f, 0.0f/255.0f, 255.0f/255.0f);
		QuestionTimerText.color = Color.white;
		CharacterHealth.currentHealth = 25f;
		QuestionsControl.randomQuestion = -1;
		questionsAnwered++;
		StartCoroutine (DisplayWrongText ());
	}

	public IEnumerator DisplayCorrectText () {

		correctText.color = Color.green;	
		correctText.text = "CORRECT";
		yield return new WaitForSeconds (1);
		correctText.text = " ";
		yield return new WaitForSeconds (1);
		questionAnsweredCorrectly = 1;
	}

	public IEnumerator DisplayWrongText () {

		correctText.color = Color.red;
		correctText.text = "WRONG";
		yield return new WaitForSeconds (1);
		correctText.text = " ";
		yield return new WaitForSeconds (1);
		questionAnsweredCorrectly = 1;
		deathReason = 5;
	}

	public IEnumerator DisplayCategoryText(){

		correctText.color = new Color (223.0f/255.0f, 62.0f/255.0f, 255.0f/255.0f);
		if (selectedCategory == 1) {
			correctText.text = "Maths!";
		} else if (selectedCategory == 2) {
			correctText.text = "Geography!";
		}
		yield return new WaitForSeconds (1.5f);
		correctText.text = " ";
		yield return new WaitForSeconds (1.5f);
		questionAnsweredCorrectly = 1;
	}

	public void StartQuestionTimer() {

		QuestionTimer -= Time.deltaTime;
		QuestionTimerText.text = QuestionTimer.ToString ("N0");
		if(QuestionTimer < 3.50f && QuestionTimer >= 0){
			QuestionTimerText.color = Color.red;
		}

	}

	public void StartNextQuestionTimer (){

		if (questionTime == false && Tim.deadStatus == false) {
			nextQuestionTimer -= Time.deltaTime;
			if (nextQuestionTimer < 1000) {
				nextQuestionTimerText.text = "Next Question: " + nextQuestionTimer.ToString ("N0");
			} else {
				nextQuestionTimerText.text = "NO MORE QUESTIONS!";
			}
			if(nextQuestionTimer < 3.50f && nextQuestionTimer >= 0){
				nextQuestionTimerText.color = Color.red;
				nextQuestionTimerText.fontSize = 26;
			}

			if(nextQuestionTimer < 0.0f){
				DisplayQuestion ();
			}
		}

	}

	public void StartTotalTime(){
		if (questionTime == false && Tim.deadStatus == false) {
			totalTime += Time.deltaTime;
		}
	}

	public void IncreaseGameSpeed(){

		scrollSpeed = (scrollSpeed - (float)0.06); 			
		tunaSpeed = (tunaSpeed - (float)0.05);
		enemySpeed = (enemySpeed - (float)0.06);

	}

	public void DisplayTotalTime(){

		if (totalTime > 0.95f && totalTime <= 1.49f) {
			totalTimeText.text = "Time Survived: " + totalTime.ToString ("N0") + " Second";
		}

		if (totalTime > 1.49f) {
			totalTimeText.text = "Time Survived: " + totalTime.ToString ("N0") + " Seconds";
		}
	}

	public void SelectDeathReason(){
		switch(deathReason){
			case 8:
				deathReasonText.text = "You were scratched by the pufferfish!";
			break;
			case 7:
				deathReasonText.text = "The crab catches its food!";
			break;
			case 6:
				deathReasonText.text = "The shark found its prey!";
			break;
			case 5:
				deathReasonText.text = "You were slayed by the mighty kraken!";
				break;
			case 4:
				deathReasonText.text = "You ran out of time!";
				break;	
			case 3:
				deathReasonText.text = "You lost all of your health!";
				break;
			case 2:
				deathReasonText.text = "You got The question wrong!";
				break;
			case 1:
				deathReasonText.text = "You were stung by a jellyfish!";
				break;
			default:
				deathReasonText.text = "You Died!";
				break;
		}
	}

	public void ChooseCategory(){

		categoryTime = true;
		CategoryTime.SetActive (true);
		QuestionBackground.SetActive (true);

	}

	public void CompleteCategory(){

		BackgroundMusic.Play ();
		categoryTime = false;
		CategoryTime.SetActive (false);
		QuestionBackground.SetActive (false);
		StartCoroutine (DisplayCategoryText());

	}

}
