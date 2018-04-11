using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrcollingBackground : MonoBehaviour {
	float scrollingSpeed = -1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!BirdScript.dead){
			transform.Translate(new Vector3(1, 0, 0) * scrollingSpeed* Time.deltaTime);
			if (transform.position.x < -20.4f) {
					transform.position = new Vector3(20.4f, transform.position.y, transform.position.z);
				}
		}
	}
}
