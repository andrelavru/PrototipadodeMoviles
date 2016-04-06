using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class conta : MonoBehaviour {

	// Use this for initialization
	public Text Conta;
	float elapsed;
	int score;

	void Start () {
		score = 0;
		elapsed = 0;
		Conta.text = score.ToString();
	}

	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;
		if(elapsed >= 1f){
			elapsed = 0;
			score++;
			Conta.text = score.ToString ();
		}
	}
}
