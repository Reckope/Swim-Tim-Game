using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : MonoBehaviour {

	public static Vector2 initialPositionSquid = new Vector2 (13f, 0.55f);

	public static bool spawnSquid = false;

	private bool squidStopped = false;
	private float speed = 5f;
	private float direction = -1f;


	// Use this for initialization
	void Start () {

		transform.position = initialPositionSquid;

	}

	// Update is called once per frame
	void Update () {

		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == false) {

			if (GameControl.instance.questionAnsweredCorrectly == 2) {
				MoveSquidBack ();
			}

			if(GameControl.instance.questionAnsweredCorrectly == 3){
				SquidAttack ();
			}
		}

		else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == true) { 

			MoveSquid ();

		}

	}

	void MoveSquid(){

		direction = -1;
		transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);

		if (transform.position.x > -15f && transform.position.x < 6f && squidStopped == false) {

			if(speed >= 0.00f){
				speed -= Time.deltaTime * 4f;
			}

			if(speed < 1f){

				speed = 0.00f;

			}
		}

	}

	void MoveSquidBack(){

		speed = 5f;
		direction = 1;
		if (transform.position.x <= 13f) {
			transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);
		}
			if(speed >= 0.00f){
				speed -= Time.deltaTime * 4f;
			}

			if(speed < 1f){

				speed = 0.00f;

			}
	}

	void SquidAttack(){

		speed = 7f;
		direction = -1;
		transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);

	}

	private void OnTriggerEnter2D (Collider2D other){
		if (other.GetComponent<Tim> () != null) {
			GameControl.deathReason = 5;
			Tim.rb2d.velocity = (new Vector2 (-5f, 0));
			GameControl.instance.TimDied ();
		}
	}
}
