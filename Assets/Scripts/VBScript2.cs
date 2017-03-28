using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript2 : MonoBehaviour, IVirtualButtonEventHandler {

	private bool released3;
	private bool released4;
	private GameObject VirtualButton3;
	private GameObject VirtualButton4;
	private GameObject Tile3;
	private GameObject Tile4;
	private AudioSource audio;
	public AudioClip a3;
	public AudioClip a4;

	// Use this for initialization
	void Start () {
		released3 = true;
		released4 = true;
		VirtualButton3 = GameObject.Find("VB Tile (3)");
		VirtualButton4 = GameObject.Find("VB Tile (4)");
		VirtualButton3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Tile3 = GameObject.Find("Tile (3)");
		Tile4 = GameObject.Find("Tile (4)");
		audio = this.GetComponentInParent<AudioSource>();
		Debug.Log("STARTED");
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		if (released3 && vb.VirtualButtonName == "VB Tile (3)") {
			audio.PlayOneShot(a3);
			Tile3.transform.Rotate(-6f,0f,0f);
			released3 = false;
		}
		if (released4 && vb.VirtualButtonName == "VB Tile (4)") {
			audio.PlayOneShot(a4);
			Tile4.transform.Rotate(-6f,0f,0f);
			released4 = false;
		}
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		if (!released3 && vb.VirtualButtonName == "VB Tile (3)") {
			Tile3.transform.Rotate(6f,0f,0f);
			released3 = true;
		}
		if (!released4 && vb.VirtualButtonName == "VB Tile (4)") {
			Tile4.transform.Rotate(6f,0f,0f);
			released4 = true;
		}
	}
}
