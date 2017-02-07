using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class OnlineController : NetworkBehaviour
{

    public static OnlineController instance;

    public Player dummyPlayer;

    public Transform testCube;

    Player[] players;

    private int activePlayerIndex = 0;
    private Connect4Board board;

    // Use this for initialization
    void Start () {
        players = FindObjectsOfType<Player>();
        if(players.Length == 0)
        {
            players = new Player[1];
            players[0] = Instantiate(dummyPlayer);
        }
        players[activePlayerIndex].isActive = true;

        board = FindObjectOfType<Connect4Board>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void Awake()
    {
        instance = this;
    }

    void OnDestroy()
    {
        instance = null;
    }



    public void PlayerSetChipRequest(Player player, int column)
    {
        board.SetChip(player, column);

       
    }

   

}
