using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Category2 : MonoBehaviour, IPointerDownHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GameControl.instance.category2Text.text = "Geography";
		
	}

	public void OnPointerDown (PointerEventData eventData) {

		GameControl.instance.selectedCategory = 2;
		GameControl.instance.CompleteCategory ();
		Debug.Log ("Cat: " + GameControl.instance.selectedCategory);

	}
}
