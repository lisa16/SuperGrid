using UnityEngine;
using System.Collections;

public class RPCBroadcastScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    [RPC]
    public void PlayerReadyBroadcast()
    {
        //check if everyone pressed ready.
        //if they did, execute StartGameBroadcast
    }

    [RPC]
    public void StartGameBroadcast()
    {

    }
}
