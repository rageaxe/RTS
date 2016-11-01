using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
	
	public Camera camera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OnStartLocalPlayer() {
		camera.enabled = true;
		GetComponent<MeshRenderer>().material.color = Color.green;
	}
}
