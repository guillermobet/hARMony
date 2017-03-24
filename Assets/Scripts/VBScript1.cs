using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript1 : MonoBehaviour, IVirtualButtonEventHandler {

	private bool released1;
	private bool released2;
	private bool released3;
	private bool released4;
	private GameObject VirtualButton1;
	private GameObject VirtualButton2;
	private GameObject VirtualButton3;
	private GameObject VirtualButton4;
	private GameObject Tile1;
	private GameObject Tile2;
	private GameObject Tile3;
	private GameObject Tile4;
	private AudioSource audio;
	public AudioClip a1;
	public AudioClip a2;
	public AudioClip a3;
	public AudioClip a4;

	// Use this for initialization
	void Start () {
		released1 = true;
		released2 = true;
		released3 = true;
		released4 = true;
		VirtualButton1 = GameObject.Find("VB Tile (1)");
		VirtualButton2 = GameObject.Find("VB Tile (2)");
		VirtualButton3 = GameObject.Find("VB Tile (3)");
		VirtualButton4 = GameObject.Find("VB Tile (4)");
		VirtualButton1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Tile1 = GameObject.Find("Tile (1)");
		Tile2 = GameObject.Find("Tile (2)");
		Tile3 = GameObject.Find("Tile (3)");
		Tile4 = GameObject.Find("Tile (4)");
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
		if (!released1 && vb.VirtualButtonName == "VB Tile (1)") {
			Tile1.transform.Rotate(6f,0f,0f);
			released1 = true;
		}
		if (!released2 && vb.VirtualButtonName == "VB Tile (2)") {
			Tile2.transform.Rotate(6f,0f,0f);
			released2 = true;
		}
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
