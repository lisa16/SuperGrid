using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetInputText : MonoBehaviour {

    public HostData[] hostList;
    private string roomName;
    private bool isServerStarted = false;
    const string PREFIX = "SG2015";
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
        Debug.Log("Created Server!");
    }

    public void JoinRoom()
    {
        InputField inputField = this.GetComponent<InputField>();
        roomName = inputField.text;
        RefreshHostList();
    }

    void OnConnectedToServer()
    {
        Debug.Log("Server existing Joined");
    }


}
