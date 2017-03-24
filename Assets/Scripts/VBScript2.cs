using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript2 : MonoBehaviour, IVirtualButtonEventHandler {

	private bool released5;
	private bool released6;
	private bool released7;
	private bool released8;
	private GameObject VirtualButton5;
	private GameObject VirtualButton6;
	private GameObject VirtualButton7;
	private GameObject VirtualButton8;
	private GameObject Tile5;
	private GameObject Tile6;
	private GameObject Tile7;
	private GameObject Tile8;
	private AudioSource audio;
	public AudioClip a5;
	public AudioClip a6;
	public AudioClip a7;
	public AudioClip a8;

	// Use this for initialization
	void Start () {
		released5 = true;
		released6 = true;
		released7 = true;
		released8 = true;
		VirtualButton5 = GameObject.Find("VB Tile (5)");
		VirtualButton6 = GameObject.Find("VB Tile (6)");
		VirtualButton7 = GameObject.Find("VB Tile (7)");
		VirtualButton8 = GameObject.Find("VB Tile (8)");
		VirtualButton5.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton6.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton7.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButton8.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Tile5 = GameObject.Find("Tile (5)");
		Tile6 = GameObject.Find("Tile (6)");
		Tile7 = GameObject.Find("Tile (7)");
		Tile8 = GameObject.Find("Tile (8)");
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
		if (!released5 && vb.VirtualButtonName == "VB Tile (5)") {
			Tile5.transform.Rotate(6f,0f,0f);
			released5 = true;
		}
		if (!released6 && vb.VirtualButtonName == "VB Tile (6)") {
			Tile6.transform.Rotate(6f,0f,0f);
			released6 = true;
		}
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
