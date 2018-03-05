using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour {

	Vector2 initialPositionJellyfish = new Vector2 (11f, 0f);
	public GameObject target;

	private float speed = 2.5f;
	private float followSpeed = 3.5f;
	private float direction = -1f;
	private float timPosition;

	// Use this for initialization
	void Start () {

		transform.position = initialPositionJellyfish;
		
	}
	
	// Update is called once per frame
	void Update () {

		timPosition = Tim.timCurrentPosition.y;

		if (GameControl.instance.gameOver == true || GameControl.instance.questionTime == true) {

		}

		else if (GameControl.instance.gameOver == false || GameControl.instance.questionTime == false) { 
			MoveJellyFish ();

			if (transform.position.x <= -15f) {
				RespawnJellyfish ();
			}
		}

	}

	void MoveJellyFish(){
				
		if(transform.position.x > (target.transform.position.x + 2f)){
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, followSpeed * Time.deltaTime);
		}
		if(transform.position.x < (target.transform.position.x + 2f)){
			transform.Translate (direction * speed * Time.deltaTime * 1, 0, 0);
		}
	}

	void RespawnJellyfish(){

		transform.position = new Vector2 (11f, timPosition);
		
	}


}


/* References:
 * Unity 2D C# Follow Gameobject. http://theflyingkeyboard.net/unity/unity-2d-c-follow-gameobject/. Accessed 05/03/18.
*/
