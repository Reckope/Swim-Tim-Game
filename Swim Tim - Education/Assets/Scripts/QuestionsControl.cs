using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsControl : MonoBehaviour {

	List<string> questions = new List<string>() {
		"Which two numbers add up to make 100?", 			// 0
		"What is the sum of 200, 300, 150 and 250?", 		// 1
		"What is the missing number?    87 + ? = 130", 		// 2
		"What is 316 + 500?",								// 3
		"What is the missing number?    378 + ? = 400",		// 4
		"Which two numbers add up to make 210?",			// 5
		"What is the missing number?    258 + ? = 278",		// 6
		"What is 115 - 25?",								// 7
		"What is the missing number?    260 + ? = 500",		// 8
		"Which two numbers add up to make 68?"				// 9
	
	};

	List<string> correctAnswer = new List<string>() {
		"2", 	// 0
		"1", 	// 1
		"3", 	// 2
		"4",	// 3
		"2",	// 4
		"1",	// 5
		"3",	// 6
		"4",	// 7
		"3",	// 8
		"1"		// 9
	
	};

	public static string selectedAnswer;
	public static bool choiceSelected = false;

	public static int randomQuestion = -1;

	void Start () {
		
		//GameControl.instance.questionText.text = questions [0];
		
	}
		
	void Update () {

		if (randomQuestion == -1) {
			randomQuestion = Random.Range (0, 9);
			//randomQuestion = 2;
		}

		if (randomQuestion > -1) {
			GameControl.instance.questionText.text = questions [randomQuestion];
		}

		if (choiceSelected == true) {

			choiceSelected = false;

			if (correctAnswer [randomQuestion] == selectedAnswer) {

				Debug.Log ("CORRECT");

				//GameControl.instance.correctText.text = "CORRECT";
				GameControl.instance.completeQuestion (); 
				
			}

			else if (correctAnswer [randomQuestion] != selectedAnswer) {

				Debug.Log ("WRONG");
				GameControl.instance.questionTime = false;
				GameControl.deathReason = 2;
				GameControl.instance.TimDied ();
			}
			
		}
		
	}
}
