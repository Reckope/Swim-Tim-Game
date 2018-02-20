using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

	//private BoxCollider2D collider;
	private float horizontalLength = 13.29f;	//13.7

	// Use this for initialization
	void Start () {

		//collider = GetComponent<BoxCollider2D> ();
		//horizontalLength = 13.9f;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x <= -horizontalLength) {
			RepositionBackground ();
		}
	}

	private void RepositionBackground() {

		//Vector2 backgroundOffset = new Vector2 (horizontalLength * 1.8f, 0);
		Vector2 backgroundOffset = new Vector2 (26.66f, 0);
		transform.position = (Vector2) transform.position + backgroundOffset;
		
	}
}
