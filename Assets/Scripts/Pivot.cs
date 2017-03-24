using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		this.transform.Rotate(-5f, 0f, 0f);
	}

	void OnMouseUp() {
		this.transform.Rotate(5f, 0f, 0f); 
	}
	
}
