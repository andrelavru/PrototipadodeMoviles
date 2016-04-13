using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class Player : MonoBehaviour {

	// Use this for initialization
	Button yellow,red,blue,green;
	string currentAnimation;
	List<string> states ;
	Animator anim;
	void Start () {
		states = new List<string> (currentAnimation);
		yellow = GameObject.Find ("yellow").GetComponent<Button>();
		red = GameObject.Find ("red").GetComponent<Button>();
		blue = GameObject.Find ("blue").GetComponent<Button>();
		green = GameObject.Find ("green").GetComponent<Button>();
		states.Add ("green");
		states.Add ("yellow");
		states.Add ("red");
		states.Add ("blue");
		anim = GetComponent<Animator>();
		int index = Random.Range (1, states.Count); 
		currentAnimation = states [index];
		anim.Play (currentAnimation);

		blue.onClick.AddListener (()=>changeBlue());
		red.onClick.AddListener (()=>changeRed());
		green.onClick.AddListener (()=>changeGreen());
		yellow.onClick.AddListener (()=>changeYellow());
	}

	void changeYellow(){
		currentAnimation = "yellow";
		anim.Play (currentAnimation);
	}

	void changeGreen(){
		currentAnimation = "green";
		anim.Play (currentAnimation);
	}
		
	void changeRed(){
		currentAnimation = "red";
		anim.Play (currentAnimation);
	}

	void changeBlue(){
		currentAnimation = "blue";
		anim.Play (currentAnimation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		Destroy (coll.gameObject);
	}
}
