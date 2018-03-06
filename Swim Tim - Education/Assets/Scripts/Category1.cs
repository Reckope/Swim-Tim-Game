using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Category1 : MonoBehaviour, IPointerDownHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GameControl.instance.category1Text.text = "Maths";
		
	}

	public void OnPointerDown (PointerEventData eventData) {

		GameControl.instance.selectedCategory = 1;
		GameControl.instance.CompleteCategory ();

	}
}
