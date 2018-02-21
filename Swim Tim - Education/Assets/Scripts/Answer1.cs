using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer1 : MonoBehaviour, IPointerDownHandler {

	List<string> firstChoice = new List<string>() {"4", "7", "2", "5"};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (QuestionsControl.randomQuestion > -1) {
			GameControl.instance.firstChoiceText.text = firstChoice [QuestionsControl.randomQuestion];
		}
		
	}

	public void OnPointerDown (PointerEventData eventData) {
		Debug.Log ("WRONG 1");
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "1";
		QuestionsControl.choiceSelected = true;

	}
}
