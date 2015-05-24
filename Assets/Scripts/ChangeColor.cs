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

        GameObject[] playerButtons = GameObject.FindGameObjectsWithTag("PlayerButton");
        foreach(GameObject go in playerButtons)
        {
            if (go.GetComponentInChildren<Image>().color != Color.red)
                return;
        }

        Debug.Log("Everyone is Ready!!!");
    }
}
