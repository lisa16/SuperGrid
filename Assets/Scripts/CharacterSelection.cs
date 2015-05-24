using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour {
    public static GameObject currentGameObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}

    public void PlayerChangeColor()
    {
        Image currImg = currentGameObject.GetComponentInChildren<Image>();
        currImg.color = Color.red;
    }
}
