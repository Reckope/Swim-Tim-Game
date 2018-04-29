using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswersControl : MonoBehaviour {

	List<string> firstChoice = new List<string>() {"First Choice", "Second Choice", "Third Choice", "Fourth Choice"};
	List<string> secondChoice = new List<string>() {"First Choice", "Second Choice", "Third Choice", "Fourth Choice"};
	List<string> thirdChoice = new List<string>() {"First Choice", "Second Choice", "Third Choice", "Fourth Choice"};
	List<string> fourthChoice = new List<string>() {"First Choice", "Second Choice", "Third Choice", "Fourth Choice"};

	// Use this for initialization
	void Start () {

		//GameControl.instance.firstChoiceText.text = firstChoice [0];
		//GameControl.instance.secondChoiceText.text = secondChoice [0];
		//GameControl.instance.thirdChoiceText.text = thirdChoice [0];
		//GameControl.instance.fourthChoiceText.text = fourthChoice [0];
		
	}
	
	// Update is called once per frame
	void Update () {

		if (QuestionsControl.randomQuestion > -1) {
			GameControl.instance.firstChoiceText.text = firstChoice [QuestionsControl.randomQuestion];
			GameControl.instance.secondChoiceText.text = secondChoice [QuestionsControl.randomQuestion];
			GameControl.instance.thirdChoiceText.text = thirdChoice [QuestionsControl.randomQuestion];
			GameControl.instance.fourthChoiceText.text = fourthChoice [QuestionsControl.randomQuestion];
		}
		
	}

	void OnMouseDown() {


	}
}
