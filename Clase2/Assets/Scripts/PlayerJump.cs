using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body;
	bool canJump;
	Button jumpButton;
	public float jumpPower = 12.0f;
	void Start () {
		body = GetComponent<Rigidbody2D>();
		jumpButton = GameObject.Find("boton_salto").GetComponent<Button>();
		jumpButton.onClick.AddListener (() => jump ());
		canJump = false;

	}
	
	// Update is called once per frame
	void jump () {
		if (canJump) {
			canJump = false;
			body.velocity = new Vector2(body.velocity.x, jumpPower);
		}
			
	}

	void Update () {
		if (Mathf.Abs (body.velocity.y) == 0) {
			canJump = true;
		}
	}
}
