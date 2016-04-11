using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body;
	bool canJump;
	Button jumpButton;
	Animator anim;
	public float jumpPower = 5.0f;
	const string RUNNING = "running";
	const string JUMPING = "jumping";
	const string IDLE = "idle";

	void Start () {
		body = GetComponent<Rigidbody2D>();
		jumpButton = GameObject.Find("boton_salto").GetComponent<Button>();
		jumpButton.onClick.AddListener (() => jump ());
		anim = GetComponent<Animator> ();
		anim.Play (RUNNING);
		canJump = false;

	}
	
	// Update is called once per frame
	void jump () {
		if (canJump) {
			canJump = false;
			anim.Play (JUMPING);
			body.velocity = new Vector2(body.velocity.x, jumpPower);
		}
			
	}

	void Update () {
		if (Mathf.Abs (body.velocity.y) == 0) {
			canJump = true;
			anim.Play (RUNNING);
		}
	}
}
