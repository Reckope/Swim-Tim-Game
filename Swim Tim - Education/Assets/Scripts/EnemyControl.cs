using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

	public GameObject shark;
	public GameObject crab;
	public GameObject jellyfish;
	public GameObject pufferfish;
	//public GameObject squid;

	// Use this for initialization
	void Start () {

		shark.SetActive (false);
		crab.SetActive (false);
		jellyfish.SetActive (false);
		pufferfish.SetActive (false);
		//squid.SetActive (false);
		
	}

	// Update is called once per frame
	void Update () {

		if (GameControl.questionsAnwered < 1) {
			shark.SetActive (false);
			crab.SetActive (false);
			jellyfish.SetActive (false);
			pufferfish.SetActive (false);
		}
		if (GameControl.questionsAnwered >= 1 && GameControl.questionsAnwered < 2) {
			Level1 ();
		}
		if (GameControl.questionsAnwered >= 2 && GameControl.questionsAnwered < 3) {
			Level2 ();
		}
		if (GameControl.questionsAnwered >= 3 && GameControl.questionsAnwered < 4) {
			Level3 ();
		}
		if (GameControl.questionsAnwered >= 4 && GameControl.questionsAnwered < 5) {
			Level4 ();
		}
		if (GameControl.questionsAnwered >= 5 && GameControl.questionsAnwered < 6) {
			Level5 ();
		}
		if (GameControl.questionsAnwered >= 6 && GameControl.questionsAnwered < 7) {
			Level6 ();
		}
		if (GameControl.questionsAnwered >= 7 && GameControl.questionsAnwered < 8) {
			Level7 ();
		}
		if (GameControl.questionsAnwered >= 8 && GameControl.questionsAnwered < 9) {
			Level8 ();
		}
		if (GameControl.questionsAnwered >= 9 && GameControl.questionsAnwered < 10) {
			Level9 ();
		}
		if (GameControl.questionsAnwered >= 10) {
			Level10 ();
		}
	}

	private void Level1(){

		shark.SetActive (false);
		crab.SetActive (false);
		jellyfish.SetActive (true);
		pufferfish.SetActive (false);
	}

	private void Level2(){
		shark.SetActive (false);
		crab.SetActive (true);
		jellyfish.SetActive (true);
		pufferfish.SetActive (false);
	}

	private void Level3(){
		shark.SetActive (false);
		crab.SetActive (false);
		jellyfish.SetActive (false);
		pufferfish.SetActive (true);
	}

	private void Level4(){
		shark.SetActive (false);
		crab.SetActive (true);
		jellyfish.SetActive (false);
		pufferfish.SetActive (true);
	}

	private void Level5(){
		shark.SetActive (true);
		crab.SetActive (false);
		jellyfish.SetActive (false);
		pufferfish.SetActive (false);
	}

	private void Level6(){
		shark.SetActive (true);
		crab.SetActive (true);
		jellyfish.SetActive (false);
		pufferfish.SetActive (false);
	}

	private void Level7(){
		shark.SetActive (false);
		crab.SetActive (false);
		jellyfish.SetActive (true);
		pufferfish.SetActive (true);
	}

	private void Level8(){
		shark.SetActive (false);
		crab.SetActive (true);
		jellyfish.SetActive (true);
		pufferfish.SetActive (true);
	}

	private void Level9(){
		shark.SetActive (true);
		crab.SetActive (true);
		jellyfish.SetActive (true);
		pufferfish.SetActive (false);
	}

	private void Level10(){
		shark.SetActive (true);
		crab.SetActive (true);
		jellyfish.SetActive (true);
		pufferfish.SetActive (true);
	}
				
}