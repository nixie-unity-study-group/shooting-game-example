using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualPilot : MonoBehaviour {
	public float moveVelocity = 0.1f;
	public float maxRange = 5.0f;
	private Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
	private Vector2 nextPosition = new Vector2(transform.position.x, transform.position.y);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition = new Vector2(transform.position.x, transform.position.y);
		nextPosition = getNextPosition();
		transform.position = Vector2.MoveTowards(currentPosition, nextPosition, moveVelocity);	
	}


	Vector2 getNextPosition() {
		Vector2 pos = new Vector2(transform.position.x, transform.position.y);
		if (Input.GetKey(KeyCode.UpArrow)) {
			pos = new Vector2(transform.position.x, maxRange);
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			pos = new Vector2(transform.position.x, -maxRange);
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			pos = new Vector2(-maxRange, transform.position.y);
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			pos = new Vector2(maxRange, transform.position.y);
		}
		return pos;
	}
}
