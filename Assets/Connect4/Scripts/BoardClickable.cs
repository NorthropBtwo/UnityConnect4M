using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardClickable : MonoBehaviour {


    public int column = -1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        //Vector3 spawnpoint = transform.position;
        //spawnpoint.y = 5;
        //Instantiate(testCube, spawnpoint, Quaternion.identity);
        foreach(Player player in FindObjectsOfType<Player>())
        {
            if (player.isLocalPlayer)
            {
                player.OnPlayerClickedOnBoard(column);
            }
        }
    }
}
