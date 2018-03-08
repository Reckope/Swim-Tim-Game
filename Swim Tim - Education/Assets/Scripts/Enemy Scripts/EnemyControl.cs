using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

	public GameObject shark;
	public GameObject crab;
	public GameObject jellyfish;
	public GameObject pufferfish;
	//public GameObject squid;

	public static float enemyPositionY = -15f;
	public static float crabPositionY = -3.8f;

	public static bool spawnJellyfish = false;
	public static bool spawnShark = false;
	public static bool spawnPufferfish = false;
	public static bool spawnCrab = false;

	// Use this for initialization
	void Start () {

		spawnShark = false;
		spawnCrab = false;
		spawnJellyfish = false;
		spawnPufferfish = false;
		//squid.SetActive (false);
		
	}

	// Update is called once per frame
	void Update () {

		if (GameControl.questionsAnwered < 1) {
			spawnShark = false;
			spawnCrab = false;
			spawnJellyfish = false;
			spawnPufferfish = false;
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

		spawnShark = false;
		spawnCrab = false;
		spawnJellyfish = true;
		spawnPufferfish = false;
	}

	private void Level2(){
		spawnShark = false;
		spawnCrab = true;
		spawnJellyfish = true;
		spawnPufferfish = false;
	}

	private void Level3(){
		spawnShark = false;
		spawnCrab = false;
		spawnJellyfish = false;
		spawnPufferfish = true;
	}

	private void Level4(){
		spawnShark = false;
		spawnCrab = true;
		spawnJellyfish = false;
		spawnPufferfish = true;
	}

	private void Level5(){
		spawnShark = true;
		spawnCrab = false;
		spawnJellyfish = false;
		spawnPufferfish = false;
	}

	private void Level6(){
		spawnShark = true;
		spawnCrab = true;
		spawnJellyfish = false;
		spawnPufferfish = false;
	}

	private void Level7(){
		spawnShark = false;
		spawnCrab = false;
		spawnJellyfish = true;
		spawnPufferfish = true;
	}

	private void Level8(){
		spawnShark = false;
		spawnCrab = true;
		spawnJellyfish = true;
		spawnPufferfish = true;
	}

	private void Level9(){
		spawnShark = true;
		spawnCrab = true;
		spawnJellyfish = true;
		spawnPufferfish = false;
	}

	private void Level10(){
		spawnShark = true;
		spawnCrab = true;
		spawnJellyfish = true;
		spawnPufferfish = true;
	}
				
}