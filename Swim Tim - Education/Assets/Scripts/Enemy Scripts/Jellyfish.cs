using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Jellyfish : MonoBehaviour {

	Vector2 initialPositionJellyfish = new Vector2 (11f, EnemyControl.enemyPositionY);
	public GameObject target;

	private float speed = 2.5f;
	private float followSpeed = 3.5f;
	private float direction = -1f;
	public static float timPosition;

	public AudioSource ZapSound;

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

			if (EnemyControl.spawnJellyfish == true) {
				
				if(transform.position.y < -5f){
					RespawnJellyfish ();
				}

				MoveJellyFish ();
			
				if (transform.position.x <= -15f) {
					RespawnJellyfish ();
				}
			} else if (EnemyControl.spawnJellyfish == false) {
				MoveToPool ();
			}
		}

	}

	void MoveJellyFish(){
				
		if(transform.position.x > (target.transform.position.x + 3f)){
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, followSpeed * Time.deltaTime);
		}
		if(transform.position.x < (target.transform.position.x + 3f)){
			transform.Translate (direction * speed * Time.deltaTime * 1.2f, 0, 0);
		}

	}

	void RespawnJellyfish(){

		transform.position = new Vector2 (7.5f, timPosition);
		ZapSound.Play ();
		
	}

	void MoveToPool(){

		transform.position = new Vector2 (11f, EnemyControl.enemyPositionY);
		ZapSound.Stop ();
	}

	private void OnTriggerEnter2D (Collider2D other){
		if (other.GetComponent<Tim> () != null) {
			GameControl.deathReason = 1;
			Tim.rb2d.velocity = (new Vector2 (-5f, 0));
			GameControl.instance.TimDied ();
		}
	}


}


/* References:
 * Unity 2D C# Follow Gameobject. http://theflyingkeyboard.net/unity/unity-2d-c-follow-gameobject/. Accessed 05/03/18.
*/
