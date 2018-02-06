using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	void Start()
	{
	}

	void Update(){

		gameObject.SetActive(true);

	}

	private void OnTriggerEnter2D (Collider2D other)			// When Tim collects the fish food...
	{
		if (other.GetComponent<Tim> () != null) 
		{
			GameControl.instance.TimScored ();					// Add 1 to the score
			//GameControl.instance.scrollSpeed = (GameControl.instance.scrollSpeed - (float)0.2); 			// Make the game go faster when a fish is collected.
			transform.position = new Vector2(-20f, -20f);		// Make foof disappear from the game camera.

		}
	}

}