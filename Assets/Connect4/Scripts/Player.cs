using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{

    public string playerName = "";
    public Color playerColor;
    public bool isActive = false;

    public Transform testCube;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnPlayerClickedOnBoard(int column)
    {
        if(isActive)
        {
            CmdPlayerClickedOnBoard(column);
        }
    }

    [Command]
    public void CmdPlayerClickedOnBoard(int column)
    {
        OnlineController.instance.PlayerSetChipRequest(this, column);
    }

}
