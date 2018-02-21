using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsControl : MonoBehaviour {

	List<string> questions = new List<string>() {"What is 2 + 2?", "What is 3 + 3?", "What is 4 + 4?", "What is 5 + 5?"};
	List<string> correctAnswer = new List<string>() {"1", "2", "3", "4"};

	public static string selectedAnswer;
	public static bool choiceSelected = false;

	public static int randomQuestion = -1;

	void Start () {
		
		//GameControl.instance.questionText.text = questions [0];
		
	}
		
	void Update () {

		if (randomQuestion == -1) {
			randomQuestion = Random.Range (0, 3);
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
			
		}
		
	}
}
