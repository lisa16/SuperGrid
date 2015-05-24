using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {

    public GameObject[] playerAnimList;
    private static GameObject myPlayerAnim;
    private static int currentScore = 0;
    private const int scoreXOffset = 5;
    private static Vector3 initTransform;

    public static GameObject litPlatform;
    public static GameObject litHospital;

    private static Vector3 initPlatformTransform;

	// Use this for initialization
	void Start () {
        myPlayerAnim = Network.Instantiate(playerAnimList[GetInputText.characterAssignedIndex], playerAnimList[GetInputText.characterAssignedIndex].transform.position, Quaternion.identity, 0) as GameObject;
        initTransform = myPlayerAnim.transform.position;
        GameObject _cam = GameObject.FindGameObjectWithTag("MainCamera");
        _cam.transform.SetParent(myPlayerAnim.transform);
        initPlatformTransform = litPlatform.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public static void IncreaseScore()
    {
        currentScore++;
        myPlayerAnim.transform.position = new Vector2(initTransform.x + scoreXOffset * currentScore, initTransform.y);
        Instantiate(litPlatform, new Vector2(initPlatformTransform.x + scoreXOffset * currentScore, initPlatformTransform.y), Quaternion.identity);
        if(currentScore == 10)
            Instantiate(litHospital);

    }
}
