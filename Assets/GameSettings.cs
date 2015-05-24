using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {

    public GameObject[] playerAnimList;
    private GameObject myPlayerAnim;
    private int currentScore = 0;
    private const int scoreXOffset = 5;
    private Vector3 initTransform;

    public GameObject litPlatform;
    public GameObject litHospital;

    private Vector3 initPlatformTransform;

    private AudioSource winningSound;

    public GameObject explodeAnimPrefab;

	// Use this for initialization
	void Start () {
        myPlayerAnim = Network.Instantiate(playerAnimList[GetInputText.characterAssignedIndex], playerAnimList[GetInputText.characterAssignedIndex].transform.position, Quaternion.identity, 0) as GameObject;
        initTransform = myPlayerAnim.transform.position;
        GameObject _cam = GameObject.FindGameObjectWithTag("MainCamera");
        _cam.transform.SetParent(myPlayerAnim.transform);
        initPlatformTransform = litPlatform.transform.position;
        winningSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void IncreaseScore()
    {
        currentScore++;
        myPlayerAnim.transform.position = new Vector2(initTransform.x + scoreXOffset * currentScore, initTransform.y);
        Instantiate(litPlatform, new Vector2(initPlatformTransform.x + scoreXOffset * currentScore, initPlatformTransform.y), Quaternion.identity);
        if(currentScore == 10)
        {
            Instantiate(litHospital);
            winningSound.Play();
        }
    }

    public void Explode()
    {
        Destroy(Instantiate(explodeAnimPrefab, myPlayerAnim.transform.position, Quaternion.identity), 2f);
    }
}
