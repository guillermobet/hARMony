using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript4 : MonoBehaviour, IVirtualButtonEventHandler {

	private bool released7;
	private bool released8;
	private GameObject VirtualButton7;
	private GameObject VirtualButton8;
	private GameObject Tile7;
	private GameObject Tile8;
	private AudioSource audio;
	public AudioClip a7;
	public AudioClip a8;

	// Use this for initialization
	void Start () {
		released7 = true;
		released8 = true;
		VirtualButton7 = GameObject.Find("VB Tile (7)");
		VirtualButton8 = GameObject.Find("VB Tile (8)");
		VirtualButton7.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton8.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Tile7 = GameObject.Find("Tile (7)");
		Tile8 = GameObject.Find("Tile (8)");
		audio = this.GetComponentInParent<AudioSource>();
		Debug.Log("STARTED");
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		if (released7 && vb.VirtualButtonName == "VB Tile (7)") {
			audio.PlayOneShot(a7);
			Tile7.transform.Rotate(-6f,0f,0f);
			released7 = false;
		}
		if (released8 && vb.VirtualButtonName == "VB Tile (8)") {
			audio.PlayOneShot(a8);
			Tile8.transform.Rotate(-6f,0f,0f);
			released8 = false;
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		if (!released7 && vb.VirtualButtonName == "VB Tile (7)") {
			Tile7.transform.Rotate(6f,0f,0f);
			released7 = true;
		}
		if (!released8 && vb.VirtualButtonName == "VB Tile (8)") {
			Tile8.transform.Rotate(6f,0f,0f);
			released8 = true;
		}
	}
}
