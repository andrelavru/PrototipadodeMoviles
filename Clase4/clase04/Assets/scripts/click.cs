using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class click : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	// Use this for initialization
	void Start () {
	
	}

	public void OnPointerDown(PointerEventData data)
	{
		print(gameObject.name + "was down");
		GameObject.Find ("player").transform.position.x += 2;
	}

	public void OnPointerUp(PointerEventData data)
	{
		print(gameObject.name + "was up");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
