using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {

	// Use this for initialization
	/*public float speed;
	Vector3 limit; 
	void Start () {
		limit = GameObject.Find ("limit").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		

		if(gameObject.activeInHierarchy)
		{
			Vector3 position = transform.position;
			position.x += speed*Time.deltaTime;
			transform.position = position;
			if (limit.x > transform.position.x) {
				gameObject.SetActive (false);
			}
		}
	}*/

	Rigidbody2D body;
	float speed = -3f;
	void Start()
	{
		body = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		if (gameObject.activeInHierarchy) 
		{
			body.velocity = new Vector2 (speed, 0);
		}
	}
}
