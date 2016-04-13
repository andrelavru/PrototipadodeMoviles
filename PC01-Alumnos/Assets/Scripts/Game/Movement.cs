using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body;

	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		body.velocity = new Vector2 (-5f, 0);                              
	}
}
