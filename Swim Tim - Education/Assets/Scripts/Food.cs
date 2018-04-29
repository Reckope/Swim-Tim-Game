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

			CharacterHealth.currentHealth = CharacterHealth.currentHealth + CharacterHealth.increaseHealth; 
			GameControl.instance.TimScored ();					// Add 1 to the score
			GameControl.instance.IncreaseGameSpeed ();
			transform.position = new Vector2(-20f, -20f);		// Make food disappear from the game camera.

		}
	}

}