using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	Button start;
	void Start () {
		start = GetComponent<Button>();
		start.onClick.AddListener(() => goGame());
	}

	void goGame(){
		SceneManager.LoadScene (1);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
