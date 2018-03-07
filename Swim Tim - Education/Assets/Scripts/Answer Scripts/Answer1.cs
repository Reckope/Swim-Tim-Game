using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer1 : MonoBehaviour, IPointerDownHandler {

	List<string> mathFirstChoice = new List<string>() {
		"38 + 52",  
		"35", 
		"900",
		"21",
		"105 + 105",
		"10",
		"60",
		"220",
		"14 + 54"
	
	};

	List<string> geoFirstChoice = new List<string>() {
		"Edinburgh",  
		"Lyon", 
		"Frankfurt",
		"Edinburgh",
		"Venice",
		"Madrid",
		"Sydney",
		"Nanjing",
		"Recife",
		"Seattle",
		"Nagoya",
		"Montreal"

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
			GameControl.instance.firstChoiceText.text = mathFirstChoice [QuestionsControl.randomQuestion];
		}
		if (QuestionsControl.randomQuestion > -1 && GameControl.instance.selectedCategory == 2){
			GameControl.instance.firstChoiceText.text = geoFirstChoice [QuestionsControl.randomQuestion];
		}

	}

	public void OnPointerDown (PointerEventData eventData) {
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "1";
		QuestionsControl.choiceSelected = true;

	}
}
