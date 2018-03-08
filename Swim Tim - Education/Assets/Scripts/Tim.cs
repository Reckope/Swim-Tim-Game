using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Tim : MonoBehaviour {

	public static Vector2 timCurrentPosition;

	public static bool deadStatus = false;
	private Rigidbody2D rb2d;
	public static Animator ani;
	public float swimUp = 5f;	

	// Use this for initialization
	void Start () 
	{
		
		rb2d = GetComponent<Rigidbody2D> ();
		ani = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		timCurrentPosition = transform.position;

		if (deadStatus == false) {
			if (GameControl.instance.questionTime == false || GameControl.instance.categoryTime == false) {

				rb2d.constraints = ~RigidbodyConstraints2D.FreezeAll;
				if (Input.GetMouseButton (0)) {
					rb2d.velocity = (new Vector2 (0, swimUp));		
					//rb2d.AddRelativeForce(new Vector2(0, swimUp));

				}
			} 
			if (GameControl.instance.questionTime == true || GameControl.instance.categoryTime == true) { 
					rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
				}
					
		}

	}

	void OnCollisionEnter2D ()
	{
		//deadStatus = true;
		ani.SetTrigger ("TimDead");				
		//bgMusic.Stop();
		if(GameControl.instance.questionAnsweredCorrectly == 1 || GameControl.instance.questionAnsweredCorrectly == 2){
			GameControl.deathReason = 1;
		}
		else if(GameControl.instance.questionAnsweredCorrectly == 3){
			rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
			GameControl.deathReason = 5;
		}
		GameControl.instance.TimDied ();	
	}

	public void TimQuestion() {

	}
}
