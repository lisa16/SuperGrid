using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour {
    public static GameObject currentGameObject;

    private NetworkView _networkView;

    AudioSource buttonClickSound;
	// Use this for initialization
	void Start () {
        _networkView = this.GetComponent<NetworkView>();
        buttonClickSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    [RPC]
    public void PlayerChangeColor()
    {
        if(_networkView.isMine)
        {
            buttonClickSound.Play();
        }
        currentGameObject.BroadcastMessage("ColorChange");
    }
}
