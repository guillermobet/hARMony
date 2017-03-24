using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
		transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
		if (Input.GetMouseButtonDown(0)) {
				this.GetComponent<AudioSource>().Play();
		}
	}
}