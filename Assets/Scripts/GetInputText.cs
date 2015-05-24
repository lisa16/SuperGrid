﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetInputText : MonoBehaviour {

    public HostData[] hostList;
    private string roomName;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RefreshHostList()
    {
        MasterServer.RequestHostList("SG2015" + roomName);
    }

    public void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        if (msEvent == MasterServerEvent.HostListReceived)
            hostList = MasterServer.PollHostList();

        // Try to join room
        RefreshHostList();
        for (int i = 0; i < hostList.Length; i++)
        {
            if (hostList[i].gameName == roomName)
            {
                JoinServer(hostList[i]);
            }
        }

        // Create room if it doesn't exist
        StartServer();
    }


    public void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
    }

    /// <summary>
    /// Create room
    /// </summary>
    /// <param name="roomName"></param>
    public void StartServer()
    {
        Network.InitializeServer(5, 25000, !Network.HavePublicAddress());
        MasterServer.RegisterHost("SG2015" + roomName, "SG2015" + roomName);
    }

    public void JoinRoom()
    {
        InputField inputField = this.GetComponent<InputField>();
        roomName = inputField.text;
        RefreshHostList();
    }

    void OnConnectedToServer()
    {
        Debug.Log("Server Joined");
    }
}