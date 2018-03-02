using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Tim : MonoBehaviour {

	public static Tim instance;

	public static bool deadStatus = false;

	private Rigidbody2D rb2d;
	public static Animator ani;

	//public AudioSource bgMusic;
	public float swimUp = 300f;									// Upward force of swimming up. (300f)

	private float movementTime = 2;
	private float lerpTime = 0.05f;

	// Use this for initialization
	void Start () 
	{
		
		rb2d = GetComponent<Rigidbody2D> ();					// Check to see if rigibody2D is attached to the object.
		ani = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (deadStatus == false) {								// If Tim is alive
			if (GameControl.instance.questionTime == false) {

				rb2d.constraints = ~RigidbodyConstraints2D.FreezeAll;
				if (Input.GetMouseButton (0)) { 						// If the player has left clicked / holding down left click.
					rb2d.velocity = (new Vector2 (0, swimUp));		
					//rb2d.AddRelativeForce(new Vector2(0, swimUp));	// Tim swim upwards.

				}
			} 
				if (GameControl.instance.questionTime == true) { 
					rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
				}
					
		}

	}

	void OnCollisionEnter2D ()									// When Tim hits the ground
	{
		//deadStatus = true;										// Tim is dead
		ani.SetTrigger ("TimDead");								// Play Animation
		//bgMusic.Stop();
		GameControl.deathReason = 1;
		GameControl.instance.TimDied ();						// Calls function from the controlGame script
	}

	public void TimQuestion() {

	}
}
