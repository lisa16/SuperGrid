using UnityEngine;
using System.Collections;

public class TutorialPages : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TutorialPage1Ok()
    {
        GameObject TutorialPage1 = GameObject.FindGameObjectWithTag("TutorialPage1") as GameObject;
        Destroy(TutorialPage1);
        GameObject TutorialPage1Button = GameObject.FindGameObjectWithTag("TutorialPage1Button") as GameObject;
        Destroy(TutorialPage1Button);
    }

    public void TutorialPage2Ok()
    {
        GameObject TutorialPage2 = GameObject.FindGameObjectWithTag("TutorialPage2") as GameObject;
        Destroy(TutorialPage2);
        GameObject TutorialPage2Button = GameObject.FindGameObjectWithTag("TutorialPage2Button") as GameObject;
        Destroy(TutorialPage2Button);
        Application.LoadLevel("StartScene");
    }

}
