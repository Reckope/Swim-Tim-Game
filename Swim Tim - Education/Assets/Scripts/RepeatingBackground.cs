using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

	//private BoxCollider2D collider;
	private float repeatPoint = 56f;	//13.7
	private float repeatPosition = 53f; 

	// Use this for initialization
	void Start () {

		//collider = GetComponent<BoxCollider2D> ();
		//horizontalLength = 13.9f;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x <= -repeatPoint) {
			RepositionBackground ();
		}

		if (transform.position.x >= repeatPosition) {
			repeatPosition = 56f;
		}
	}

	private void RepositionBackground() {

		//Vector2 backgroundOffset = new Vector2 (horizontalLength * 1.8f, 0);

		//Vector2 backgroundOffset = new Vector2 (repeatPosition, 0);
		//transform.position = (Vector2) transform.position + backgroundOffset;

		transform.position = new Vector2 (repeatPosition, 0); 	// 13.33f
		
	}
}
