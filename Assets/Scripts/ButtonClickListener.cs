using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonClickListener : MonoBehaviour {
	[HideInInspector]
	private string CurrentPlayer = "RoomPlayer4";
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SlotClicked() {
		Image img = this.gameObject.GetComponent<Image> ();
		if (img.color != Color.white) {
			return;
		} else {
			CurrentPlayer = this.gameObject.tag;
			img.color = Color.green;
		}
	}

	public void ButtonClicked() {
		if (CurrentPlayer == "") {
			return;
		}

		GameObject PlayerRoom = GameObject.FindGameObjectWithTag(CurrentPlayer) as GameObject;
		Image img = PlayerRoom.GetComponent<Image> ();
		img.color = Color.red;
	}
}
