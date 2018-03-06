using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour {

	public static Vector2 initialPositionShark = new Vector2 (11f, 0f);

	private float speed = 5f;
	private float direction = -1f;
	private float timPosition;

	private bool sharkStopped = false;


	// Use this for initialization
	void Start () {

		transform.position = initialPositionShark;
		
	}
	
	// Update is called once per frame
	void Update () {

		timPosition = Tim.timCurrentPosition.y;

		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == true) {

		}

		else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == false) { 
			MoveShark ();

			if (transform.position.x <= -15f) {
				RespawnShark ();
			}
		}
		
	}

	void MoveShark(){

		transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);

		if (transform.position.x > -15f && transform.position.x < 9f && sharkStopped == false) {

			if(speed >= 0.00f){
				speed -= Time.deltaTime * 4f;
			}

			if(speed < 1f){

				speed = 0.00f;
				StartCoroutine (IncreaseSharkSpeed ());
			}

		}
		
	}

	public IEnumerator IncreaseSharkSpeed () {

		sharkStopped = true;
		yield return new WaitForSeconds (1);
		speed = 12.5f;
		transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);
	}

	void RespawnShark(){

		transform.position = new Vector2 (11f, timPosition);
		speed = 5f;
		sharkStopped = false;
	}
}
