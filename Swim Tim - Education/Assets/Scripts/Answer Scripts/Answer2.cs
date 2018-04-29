using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer2 : MonoBehaviour, IPointerDownHandler {

	List<string> mathSecondChoice = new List<string>() {
		"53 + 47",  
		"50", 
		"800",
		"22",
		"103 + 106",
		"30",
		"70",
		"230",
		"18 + 54",
		"982",
		"380"

	};

	List<string> geoSecondChoice = new List<string>() {
		"London",  
		"Toulouse", 
		"Munich",
		"Glasgow",
		"Rome",
		"Barcelona",
		"Melbourne",
		"Shanghai",
		"Brasilia",
		"New York",
		"Osaka",
		"Toronto"

	};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(GameControl.instance.selectedCategory > 0){
			ChooseCategory ();
		}
		
	}

	void ChooseCategory (){

		if (QuestionsControl.randomQuestion > -1 && GameControl.instance.selectedCategory == 1) {
			GameControl.instance.secondChoiceText.text = mathSecondChoice [QuestionsControl.randomQuestion];
		}
		if (QuestionsControl.randomQuestion > -1 && GameControl.instance.selectedCategory == 2){
			GameControl.instance.secondChoiceText.text = geoSecondChoice [QuestionsControl.randomQuestion];
		}

	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "2";
		QuestionsControl.choiceSelected = true;
	}
}
