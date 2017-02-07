using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Chip : NetworkBehaviour {

    [SyncVar]
    public Color ShipColor = Color.white;

	// Use this for initialization
	void Start () {
        Renderer[] renderers = GetComponents<Renderer>();
        foreach(Renderer renderer in renderers)
        {
            renderer.material.color = ShipColor;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
