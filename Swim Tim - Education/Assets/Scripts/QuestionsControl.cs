using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsControl : MonoBehaviour {

	public static List<string> mathQuestions = new List<string>() {
		"Which two numbers add up to make 100?", 			// 0 
		"What is the missing number?    87 + ? = 130", 		// 2
		"What is 316 + 500?",								// 3
		"What is the missing number?    378 + ? = 400",		// 4
		"Which two numbers add up to make 210?",			// 5
		"What is the missing number?    258 + ? = 278",		// 6
		"What is 115 - 25?",								// 7
		"What is the missing number?    260 + ? = 500",		// 8
		"Which two numbers add up to make 68?",				// 9
		"What is 647 + 335?",
		"What is 580 - 180?"
	
	};

	List<string> mathCorrectAnswer = new List<string>() {
		"2", 	// 0
		"3", 	// 2
		"4",	// 3
		"2",	// 4
		"1",	// 5
		"3",	// 6
		"4",	// 7
		"3",	// 8
		"1",	// 9
		"2",
		"3"
	
	};

	List<string> geoQuestions = new List<string>() {
		"What is the capital of England?", 
		"What it the capital of France?", 
		"What is the capital of Germany?",
		"What is the capital of Scotland?",
		"What is the capital of Italy?",
		"What is the capital of Spain?",
		"What is the capital of Australia?",
		"What is the capital of China?",
		"What is the capital of Brazil?",
		"What is the capital of America?",
		"What is the capital of Japan?",
		"What is the capital of Canada?"

	};

	List<string> geoCorrectAnswer = new List<string>() {
		"2", 	
		"3", 	
		"4",
		"1",
		"2",
		"1",
		"4",
		"3",
		"2",
		"4",
		"4",
		"3"

	};

	List<int> previousQuestion = new List<int>() {
		-1, 	
		-1, 	
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1,
		-1

	};

	public static int questionNumber = 0;
	public static int numberOfQuestions = 11;
	public static string selectedAnswer;
	public static bool choiceSelected = false;
	public static int randomQuestion = -1;

	void Start () {
		
		randomQuestion = -1;
		questionNumber = 0;
	}
		
	void Update () {

		if (GameControl.instance.selectedCategory == 0) {
			ControlMathQuestion ();
		}
		else if (GameControl.instance.selectedCategory == 1) {
			ControlMathQuestion ();
		}
		else if (GameControl.instance.selectedCategory == 2) {
			ControlGeoQuestion ();
		}

	}

	// MATHS
	void ControlMathQuestion(){

		if (randomQuestion == -1) {

			randomQuestion = Random.Range (0, 11);
			for (int i = 0; i < mathQuestions.Count; i++) {
				if (randomQuestion != previousQuestion [i]) {

				}else {
					randomQuestion = -1;
				}
			}

		}

		if (randomQuestion > -1) {
			GameControl.instance.questionText.text = mathQuestions [randomQuestion];
			previousQuestion [questionNumber] = randomQuestion;
	
		}

		if (choiceSelected == true) {

			choiceSelected = false;
			questionNumber+=1;
			Debug.Log ("Q Number: " + questionNumber);
			if (mathCorrectAnswer [randomQuestion] == selectedAnswer) {

				//Debug.Log ("CORRECT");
				GameControl.instance.questionAnsweredCorrectly = 2;
				GameControl.instance.completeQuestion (); 

			}

			else if (mathCorrectAnswer [randomQuestion] != selectedAnswer) {

				//Debug.Log ("WRONG");
				GameControl.instance.questionTime = false;
				GameControl.deathReason = 2;
				GameControl.instance.questionAnsweredCorrectly = 3;
				GameControl.instance.DeathBySquid();
			}

		}

	}

	// GEOGRAPHY
	void ControlGeoQuestion(){

		if (randomQuestion == -1) {
			randomQuestion = Random.Range (0, 11);
			for (int i = 0; i < 12; i++) {
				if (randomQuestion != previousQuestion [i]) {
					
				} else {
					randomQuestion = -1;
				}
			}
				
		}

		if(questionNumber >= 11){
			questionNumber = 0;
			randomQuestion = -1;
		}

		if (randomQuestion > -1) {
			GameControl.instance.questionText.text = geoQuestions [randomQuestion];
			previousQuestion [questionNumber] = randomQuestion;
		}

		if (choiceSelected == true) {

			choiceSelected = false;
			questionNumber+=1;

			if (geoCorrectAnswer [randomQuestion] == selectedAnswer) {

				//Debug.Log ("CORRECT");
				GameControl.instance.questionAnsweredCorrectly = 2;
				GameControl.instance.completeQuestion (); 

			}

			else if (geoCorrectAnswer [randomQuestion] != selectedAnswer) {

				//Debug.Log ("WRONG");
				GameControl.instance.questionTime = false;
				GameControl.deathReason = 2;
				GameControl.instance.questionAnsweredCorrectly = 3;
				GameControl.instance.DeathBySquid();
			}

		}

	}
}
