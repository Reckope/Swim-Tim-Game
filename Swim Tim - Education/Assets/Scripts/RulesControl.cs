using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesControl : MonoBehaviour {

	public GameObject Controls;
	public GameObject Gameplay;
	public GameObject Enemies;
	public GameObject Questions;

	public static int currentPage;


	// Use this for initialization
	void Start () {

		LoadControlsPage ();
		
	}
	
	// Update is called once per frame
	void Update () {

		ChoosePage ();
		
	}

	public void ChoosePage(){

		switch (currentPage) {
		case 4:
			LoadControlsPage ();
		break;
		case 3:
			LoadGameplayPage ();
		break;
		case 2:
			LoadEnemiesPage ();
		break;
		case 1:
			LoadQuestionsPage ();
		break;
		default:
			LoadControlsPage ();
			break;
		}

	}

	void LoadControlsPage(){

		Controls.SetActive (true);
		Gameplay.SetActive (false);
		Enemies.SetActive (false);
		Questions.SetActive (false);
		currentPage = 4;
		
	}

	void LoadGameplayPage(){

		Controls.SetActive (false);
		Gameplay.SetActive (true);
		Enemies.SetActive (false);
		Questions.SetActive (false);
		currentPage = 3;
		
	}

	void LoadEnemiesPage(){

		Controls.SetActive (false);
		Gameplay.SetActive (false);
		Enemies.SetActive (true);
		Questions.SetActive (false);
		currentPage = 2;
		
	}

	void LoadQuestionsPage(){

		Controls.SetActive (false);
		Gameplay.SetActive (false);
		Enemies.SetActive (false);
		Questions.SetActive (true);
		currentPage = 1;
		
	}

	public void NextPage(){
		currentPage = currentPage - 1;
	}

	public void PreviousPage(){
		currentPage = currentPage + 1;
	}

}
