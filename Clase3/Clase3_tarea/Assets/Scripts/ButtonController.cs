using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	Button startButton;
	Button pauseButton;
	GameObject pauseParent;
	GameObject startParent;
	const string PAUSE_BUTTON = "boton_pausa";
	const string START_BUTTON = "boton_play";
	void Start () {
		pauseParent = GameObject.Find (PAUSE_BUTTON);
		pauseButton = pauseParent.GetComponent<Button> ();
		startParent = GameObject.Find (START_BUTTON);
		startButton = startParent.GetComponent<Button> ();
		pauseButton.onClick.AddListener (() => pause ());
		startButton.onClick.AddListener (() => pause ());
		startParent.SetActive (false);
	}

	void pause(){
		if (!startParent.activeInHierarchy) {
			startParent.SetActive (true);
			pauseParent.SetActive (false);
			Time.timeScale = 0;
		} else {
			startParent.SetActive (false);
			pauseParent.SetActive (true);
			Time.timeScale = 1f;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
