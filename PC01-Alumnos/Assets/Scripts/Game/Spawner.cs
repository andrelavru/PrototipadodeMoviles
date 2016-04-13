using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	public GameObject[] elements;
	float elapsed;
	float totalTime = 0;
	void Start () {
		elapsed = 0;
		totalTime = Random.Range (1.5f, 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		elapsed = Time.deltaTime;
		if (elapsed >= totalTime) {
			int index = Random.Range (0, elements.Length);
			Instantiate(elements[index], transform.position, transform.rotation);
		}
	}

}
