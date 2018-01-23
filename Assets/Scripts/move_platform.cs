using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_platform : MonoBehaviour {		// Mark Price named this script "Object.cs"

	[SerializeField] private float objectSpeed = 1;
	[SerializeField] private float resetPosition = -45.4f;
	[SerializeField] private float startPosition = 46.9f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {

		if (!GameManager.instance.GameOver){

			transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

			if (transform.localPosition.x <= resetPosition) {
				Vector3 newPos = new Vector3 (startPosition, transform.position.y, transform.position.z);
				transform.position = newPos;
			}
		}
	}
}
