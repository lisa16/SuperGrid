using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour {
    public static GameObject currentGameObject;

    private NetworkView _networkView;
	// Use this for initialization
	void Start () {
        _networkView = this.GetComponent<NetworkView>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    [RPC]
    public void PlayerChangeColor()
    {
        currentGameObject.BroadcastMessage("ColorChange");
    }
}
