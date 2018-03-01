using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour {

	public static float currentHealth { get; set; }
	public float maxHealth { get; set; }

	public static float increaseHealth = 2.5f;

	public Slider healthBar;

	private const float decreaseHealth = 1.3f;

	// Use this for initialization
	void Start () {

		maxHealth = 21f;
		currentHealth = maxHealth;

		healthBar.value = CalculateHealth ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameControl.instance.questionTime == false && GameControl.instance.gameOver == false) {
			currentHealth -= decreaseHealth * Time.deltaTime;
			healthBar.value = CalculateHealth ();
		}

		if (currentHealth <= 0) {

			GameControl.deathReason = 3;
			GameControl.instance.TimDied ();
		}

		if (currentHealth > maxHealth){

			currentHealth = maxHealth;
		}
		
	}

	float CalculateHealth () {

		return currentHealth / maxHealth;

	}
}

/* REFERENCES

 How to create a health bar in unity. https://www.youtube.com/watch?v=GfuxWs6UAJQ&feature=youtu.be. Accessed 22/02/18.

*/
