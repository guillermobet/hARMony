using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript1 : MonoBehaviour, IVirtualButtonEventHandler {

	private bool released1;
	private bool released2;
	private GameObject VirtualButton1;
	private GameObject VirtualButton2;
	private GameObject Tile1;
	private GameObject Tile2;
	private AudioSource audio;
	public AudioClip a1;
	public AudioClip a2;

	// Use this for initialization
	void Start () {
		released1 = true;
		released2 = true;
		VirtualButton1 = GameObject.Find("VB Tile (1)");
		VirtualButton2 = GameObject.Find("VB Tile (2)");
		VirtualButton1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Tile1 = GameObject.Find("Tile (1)");
		Tile2 = GameObject.Find("Tile (2)");
		audio = this.GetComponentInParent<AudioSource>();
		Debug.Log("STARTED");
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		if (released1 && vb.VirtualButtonName == "VB Tile (1)") {
			audio.PlayOneShot(a1);
			Tile1.transform.Rotate(-6f,0f,0f);
			released1 = false;
		}
		if (released2 && vb.VirtualButtonName == "VB Tile (2)") {
			audio.PlayOneShot(a2);
			Tile2.transform.Rotate(-6f,0f,0f);
			released2 = false;
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		if (!released1 && vb.VirtualButtonName == "VB Tile (1)") {
			Tile1.transform.Rotate(6f,0f,0f);
			released1 = true;
		}
		if (!released2 && vb.VirtualButtonName == "VB Tile (2)") {
			Tile2.transform.Rotate(6f,0f,0f);
			released2 = true;
		}
	}
}
