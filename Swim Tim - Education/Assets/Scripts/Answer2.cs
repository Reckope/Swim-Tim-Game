using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer2 : MonoBehaviour, IPointerDownHandler {

	List<string> secondChoice = new List<string>() {"5", "6", "20", "7"};

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
