using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript3 : MonoBehaviour, IVirtualButtonEventHandler {

	private bool released5;
	private bool released6;
	private GameObject VirtualButton5;
	private GameObject VirtualButton6;
	private GameObject Tile5;
	private GameObject Tile6;
	private AudioSource audio;
	public AudioClip a5;
	public AudioClip a6;

	// Use this for initialization
	void Start () {
		released5 = true;
		released6 = true;
		VirtualButton5 = GameObject.Find("VB Tile (5)");
		VirtualButton6 = GameObject.Find("VB Tile (6)");
		VirtualButton5.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton6.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Tile5 = GameObject.Find("Tile (5)");
		Tile6 = GameObject.Find("Tile (6)");
		audio = this.GetComponentInParent<AudioSource>();
		Debug.Log("STARTED");
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		if (released5 && vb.VirtualButtonName == "VB Tile (5)") {
			audio.PlayOneShot(a5);
			Tile5.transform.Rotate(-6f,0f,0f);
			released5 = false;
		}
		if (released6 && vb.VirtualButtonName == "VB Tile (6)") {
			audio.PlayOneShot(a6);
			Tile6.transform.Rotate(-6f,0f,0f);
			released6 = false;
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		if (!released5 && vb.VirtualButtonName == "VB Tile (5)") {
			Tile5.transform.Rotate(6f,0f,0f);
			released5 = true;
		}
		if (!released6 && vb.VirtualButtonName == "VB Tile (6)") {
			Tile6.transform.Rotate(6f,0f,0f);
			released6 = true;
		}
	}
}