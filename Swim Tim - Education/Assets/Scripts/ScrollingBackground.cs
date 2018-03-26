using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed, 0);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == true || GameControl.instance.categoryTime == true) {

			rb2d.velocity = Vector2.zero;
		}

		else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == false || GameControl.instance.categoryTime == false) {

			rb2d = GetComponent<Rigidbody2D> ();
			rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed, 0);
			//transform.Translate (-1 * -GameControl.instance.scrollSpeed * Time.deltaTime * 1, 0, 0);
		}
		
	}

}
