using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer4 : MonoBehaviour, IPointerDownHandler {

	List<string> fourthChoice = new List<string>() {
		"54 + 47",  
		"64", 
		"816",
		"44",
		"200 + 15",
		"28",
		"90",
		"250",
		"18 + 56"

	};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (QuestionsControl.randomQuestion > -1) {
			GameControl.instance.fourthChoiceText.text = fourthChoice [QuestionsControl.randomQuestion];
		}
		
	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "4";
		QuestionsControl.choiceSelected = true;
	}
}
