using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Answer4 : MonoBehaviour, IPointerDownHandler {

	List<string> fourthChoice = new List<string>() {"49", "27", "9", "10"};

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
		Debug.Log ("WRONG 4");
		//QuestionsControl.selectedAnswer = gameObject.name;
		QuestionsControl.selectedAnswer = "4";
		QuestionsControl.choiceSelected = true;
	}
}
