using UnityEngine;
using System.Collections;

public class ObejotaKeyboard : MonoBehaviour {

	// Use this for initialization
	public float speed;
	float scaleX;
	float tempD;
	float tempA;
	void Start () {
		scaleX = transform.localScale.x;
		tempA=scaleX * 1;
		tempD=scaleX * -1;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		if (Input.GetKey (KeyCode.D)) {
			position.x += speed*Time.deltaTime;
			scaleX = tempD;
		}

		if (Input.GetKey (KeyCode.A)) {
			position.x -= speed*Time.deltaTime;
			scaleX = tempA;
		}

		transform.localScale = new Vector3 (scaleX, transform.localScale.y, transform.localScale.z);
		transform.position = position;
	}

}
