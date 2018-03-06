using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer2 : MonoBehaviour, IPointerDownHandler {

	List<string> secondChoice = new List<string>() {
		"53 + 47",  
		"50", 
		"800",
		"22",
		"103 + 106",
		"30",
		"70",
		"230",
		"18 + 54"

	};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (QuestionsControl.randomQuestion > -1) {
			GameControl.instance.secondChoiceText.text = secondChoice [QuestionsControl.randomQuestion];
		}
		
	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "2";
		QuestionsControl.choiceSelected = true;
	}
}
