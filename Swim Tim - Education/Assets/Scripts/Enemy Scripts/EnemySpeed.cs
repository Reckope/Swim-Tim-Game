using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour {

	private Rigidbody2D rb2d;

	public float speed = -15f;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (speed, 0);

	}

	// Update is called once per frame
	void Update () {

		//speed = GameControl.instance.enemySpeed;

		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == true) {

			rb2d.velocity = Vector2.zero;
		}

		else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == false) {

			rb2d = GetComponent<Rigidbody2D> ();
			rb2d.velocity = new Vector2 (speed, 0);
		}
	}
}
