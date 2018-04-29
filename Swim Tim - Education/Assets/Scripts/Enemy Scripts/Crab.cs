using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Crab : MonoBehaviour {

	Vector2 initialPositionCrab = new Vector2 (11f, EnemyControl.enemyPositionY); // - 3.8
	Vector2 currentPosition;

	private float speed = 6f;
	private float direction = -1f;

	public AudioSource SnapSound;

	public static float upwardDirection = 1f;


	// Use this for initialization
	void Start () {

		transform.position = initialPositionCrab;
		upwardDirection = 1f;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == true) {
			SnapSound.Stop ();
		}

			else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == false) { 

			if (EnemyControl.spawnCrab == true) {

				if(transform.position.y < -5f){
					RespawnCrab ();
				}
				MoveCrab ();
				if (transform.position.x <= -15f) {
					RespawnCrab ();
				}
			} else if (EnemyControl.spawnCrab == false) {
				MoveToPool ();
			}
		}
	}

	void MoveCrab(){

		transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);

		if (transform.position.x > -15f && transform.position.x < -1f) {
			transform.Translate (0, upwardDirection*speed*Time.deltaTime * 1, 0);

			if (transform.position.y > -1.4) {
				SnapSound.Play ();
				upwardDirection = -1;
			}

			if (transform.position.y < -4f) {
				upwardDirection = 0f;
				transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);
			}

		}

	}

	void RespawnCrab(){

		transform.position = new Vector2 (11f, EnemyControl.crabPositionY);
		upwardDirection = 1f;

	}

	void MoveToPool(){

		transform.position = new Vector2 (11f, EnemyControl.enemyPositionY);
		SnapSound.Stop ();
	}

	private void OnTriggerEnter2D (Collider2D other){
		if (other.GetComponent<Tim> () != null) {
			GameControl.deathReason = 7;
			Tim.rb2d.velocity = (new Vector2 (-5f, 0));
			GameControl.instance.TimDied ();
		}
	}

}


