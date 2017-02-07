using Prototype.NetworkLobby;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkLobbyHook : LobbyHook {


    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
    {
        LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();
        Player localPlayer = gamePlayer.GetComponent<Player>();

        localPlayer.playerName = lobby.playerName;
        localPlayer.playerColor = lobby.playerColor;

        base.OnLobbyServerSceneLoadedForPlayer(manager, lobbyPlayer, gamePlayer);
    }

}
