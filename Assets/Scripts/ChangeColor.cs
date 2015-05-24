using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {

    NetworkView _networkView;

	// Use this for initialization
	void Start () {
        _networkView = GetComponent<NetworkView>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    [RPC]
    public void ColorChange ()
    {
        Image img = this.GetComponent<Image>();
        img.color = Color.red;

        if(_networkView.isMine)
        {
            _networkView.RPC("ColorChange", RPCMode.OthersBuffered);
        }
    }
}
