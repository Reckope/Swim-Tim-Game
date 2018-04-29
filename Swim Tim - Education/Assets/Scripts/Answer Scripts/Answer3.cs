using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer3 : MonoBehaviour, IPointerDownHandler {

	List<string> mathThirdChoice = new List<string>() {
		"22 + 77", 
		"43", 
		"616",
		"33",
		"50 + 60",
		"20",
		"80",
		"240",
		"14 + 56",
		"983",
		"400"

	};

	List<string> geoThirdChoice = new List<string>() {
		"Washington",  
		"Paris", 
		"Hamburg",
		"Inverness",
		"Florence",
		"Valencia",
		"Perth",
		"Beijing",
		"Salvador",
		"Chicago",
		"Kyoto",
		"Ottawa"



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

	void ChooseCategory(){

		if (QuestionsControl.randomQuestion > -1 && GameControl.instance.selectedCategory == 1) {
			GameControl.instance.thirdChoiceText.text = mathThirdChoice [QuestionsControl.randomQuestion];
		}
		if (QuestionsControl.randomQuestion > -1 && GameControl.instance.selectedCategory == 2){
			GameControl.instance.thirdChoiceText.text = geoThirdChoice [QuestionsControl.randomQuestion];
		}

	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "3";
		QuestionsControl.choiceSelected = true;
	}
}
