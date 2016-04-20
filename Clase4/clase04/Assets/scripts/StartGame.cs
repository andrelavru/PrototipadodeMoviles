using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	facebookControler controller;
	Button button;
	void Start () {
		controller = GameObject.Find ("Main Camera").GetComponent<facebookControler> ();
		button = GetComponent<Button> ();
		button.onClick.AddListener (()  => logInApp());
	}

	void logInApp(){
		//button.onClick.RemoveAllListeners ();
		controller.login ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
