using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour {

	Button play;
	void Start () {
		play = GetComponent<Button> ();
		play.onClick.AddListener(()=>startGame());
	}


	void startGame(){
		SceneManager.LoadScene ("Game");
	}

}
