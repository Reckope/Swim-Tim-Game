using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer4 : MonoBehaviour, IPointerDownHandler {

	List<string> mathFourthChoice = new List<string>() {
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

	List<string> geoFourthChoice = new List<string>() {
		"Manchester",  
		"Bordeaux", 
		"Berlin",
		"London",
		"Milan",
		"Malaga",
		"Canberra",
		"Tokyo",
		"Rio De Janeiro",
		"Washington DC",
		"Tokyo",
		"Vancouver"

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
			GameControl.instance.fourthChoiceText.text = mathFourthChoice [QuestionsControl.randomQuestion];
		}
		else if (QuestionsControl.randomQuestion > -1 && GameControl.instance.selectedCategory == 2){
			GameControl.instance.fourthChoiceText.text = geoFourthChoice [QuestionsControl.randomQuestion];
		}

	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "4";
		QuestionsControl.choiceSelected = true;
	}
}
