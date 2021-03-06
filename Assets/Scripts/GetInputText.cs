﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetInputText : MonoBehaviour {

    public HostData[] hostList;
    private string roomName;
    private bool isServerStarted = false;
    const string PREFIX = "SG2015";
    private readonly string[] characters = {"player1", "player2", "player3", "player4" , "player5" , "player6" , "player7" , "player8"};
    static string characterAssigned;
    public static int characterAssignedIndex;
    public GameObject[] characterPrefabs;

    private AudioSource buttonClick;

    // Use this for initialization
    void Start()
    {
        buttonClick = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RefreshHostList()
    {
        MasterServer.RequestHostList(PREFIX + roomName);

    }

    public void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        if (msEvent == MasterServerEvent.HostListReceived)
            hostList = MasterServer.PollHostList();

        // Try to join room
        for (int i = 0; i < hostList.Length; i++)
        {
            if (hostList[i].gameName == PREFIX + roomName)
            {
                JoinServer(hostList[i]);
                return;
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
        if (!isServerStarted)
        {
            Network.InitializeServer(5, 25000, !Network.HavePublicAddress());
            MasterServer.RegisterHost(PREFIX + roomName, PREFIX + roomName);
            isServerStarted = true;
        }
        
    }

    public void OnServerInitialized()
    {
        Debug.Log("Created Server!");        // Assign character number 1
        characterAssigned = characters[0];
        characterAssignedIndex = 0;
        GameObject player = Network.Instantiate(characterPrefabs[0], characterPrefabs[0].transform.position, Quaternion.identity, 0) as GameObject;
        CharacterSelection.currentGameObject = player;
        Debug.Log(characterAssigned);
    }

    public void ConnectToServer()
    {
        buttonClick.Play();
        InputField inputField = this.GetComponent<InputField>();
        roomName = inputField.text;
        RefreshHostList();
    }

    void OnConnectedToServer()
    {
        Debug.Log("Joined existing server");
        int playersConnected = int.Parse(Network.player.ToString());

        Debug.Log(playersConnected);
        characterAssigned = characters[playersConnected];
        characterAssignedIndex = playersConnected;
        GameObject player = Network.Instantiate(characterPrefabs[playersConnected], characterPrefabs[playersConnected].transform.position, Quaternion.identity, 0) as GameObject;
        CharacterSelection.currentGameObject = player;
    }
}
