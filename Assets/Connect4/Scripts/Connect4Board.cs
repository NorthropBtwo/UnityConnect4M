using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Connect4Board : NetworkBehaviour
{

    public Transform testCube;

    [Header("floating chip")]
    public int pos;


    public BoardClickable[] clickables;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool SetChip(Player player,int column)
    {

        Vector3 spawnPos = clickables[column].transform.position;
        spawnPos.y = 7;

        Transform newCube = Instantiate(testCube, spawnPos, Quaternion.identity);
        Color color = player.playerColor;
        newCube.gameObject.GetComponent<Chip>().ShipColor = color;
        NetworkServer.Spawn(newCube.gameObject);
      

        return true;
    }

 
}