using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesControl : MonoBehaviour {

	public GameObject Controls;
	public GameObject Gameplay;
	public GameObject Enemies;
	public GameObject Questions;


	// Use this for initialization
	void Start () {

		Controls.SetActive (true);
		Gameplay.SetActive (false);
		Enemies.SetActive (false);
		Questions.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
