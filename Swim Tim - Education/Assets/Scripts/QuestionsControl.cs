using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsControl : MonoBehaviour {

	List<string> questions = new List<string>() {"First Question!", "Second Question!", "Third Question!", "Fourth Question!"};

	public static int randomQuestion = -1;

	// Use this for initialization
	void Start () {
		
		//GameControl.instance.questionText.text = questions [0];
		
	}

	// Update is called once per frame
	void Update () {

		if (randomQuestion == -1) {
			randomQuestion = Random.Range (0, 3);
		}

		if (randomQuestion > -1) {
			GameControl.instance.questionText.text = questions [randomQuestion];
		}
		
	}
}
