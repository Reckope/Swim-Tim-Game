using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squid : MonoBehaviour {

	Vector2 current_position;

	private float direction = 1.0f;
	private float speed = 1.4f;
	private float heightlimit = 1f;
	private float timecount = 0.0f;
	private float timelimit = 0f;

	// Use this for initialization
	void Start () {

		current_position = this.transform.position;							// Find out the Squids current position.

	}

	// Update is called once per frame
	void Update () {

		transform.Translate (0, direction*speed*Time.deltaTime * 1, 0);

		if (transform.position.y > current_position.y+heightlimit) {
			direction = -1;
		}
		if (transform.position.y < current_position.y){
			direction = 0;
			timecount = timecount + Time.deltaTime;

			if (timecount > timelimit) {
				direction = 1;
				timecount = 0;
			}
		}

	}
}
