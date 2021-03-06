﻿using UnityEngine;
using System.Collections;

public class Scaler : MonoBehaviour {

	// Use this for initialization
	Renderer render;
	void Start () {
		render = GetComponent<Renderer> ();
		float height = Camera.main.orthographicSize * 2f;
		float width = height * Screen.width / Screen.height;
		if(gameObject.name == "bg") {
			transform.localScale = new Vector3 (width, height, 0);	
			render.sortingOrder = 0;
		}else if(gameObject.name =="ground"){
			transform.localScale = new Vector3 (width, 3f, 0);
			render.sortingOrder = 1;
		} 
	}

}
