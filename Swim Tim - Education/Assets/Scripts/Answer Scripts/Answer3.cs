using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer3 : MonoBehaviour, IPointerDownHandler {

	List<string> thirdChoice = new List<string>() {
		"22 + 77", 
		"10000", 
		"43", 
		"616",
		"33",
		"50 + 60",
		"20",
		"80",
		"240",
		"14 + 56"

	};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (QuestionsControl.randomQuestion > -1) {
			GameControl.instance.thirdChoiceText.text = thirdChoice [QuestionsControl.randomQuestion];
		}
		
	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "3";
		QuestionsControl.choiceSelected = true;
	}
}
