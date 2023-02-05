using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class LobbyManager : MonoBehaviourPunCallbacks   
{
    public Text LogText;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.NickName = "Player" + Random.Range(1000, 9999);
        Log("Player's name is set to " + PhotonNetwork.NickName);
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "Alpha.0.1.0";
        PhotonNetwork.ConnectUsingSettings();
    }

    private void Log(String message)
    {
        Debug.Log(message);
        LogText.text += "\n";
        LogText.text += message;
    }

    public void StartSingleGame()
    {
        SceneManager.LoadScene(1);
    }

    public override void OnConnectedToMaster()
    {
        Log("Connected to master server");
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions{MaxPlayers = 10});
    }   
    
    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedLobby()
    {
        Log("Joined room");
        PhotonNetwork.LoadLevel("GameTable");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
