using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class QuestionStart : MonoBehaviour {

	public QuestionClass question;

	private bool penalty = false;
	private bool timeout = false;
	private float countdown = 0.0f;
	private float timer = 0.0f;
	private float maxTimeout = 180.0f;
	private int iterate = 0;

    private AudioSource[] audioSources;

	void Start(){
		ListOfQuestions.setList();
		newQuestion ();
        audioSources = GetComponents<AudioSource>();
    }

	// Update is called once per frame
	void FixedUpdate () {
		if (penalty == true) {
			countdown = countdown + Time.deltaTime;
			if( countdown >= 5.0f) {
				penalty = false;
				countdown = 0.0f;
			}
		}

		if (timeout == false) {
			timer = timer + Time.deltaTime;
			if(timer >= maxTimeout){
				timeout = true;
			}
		}
	}

	void newQuestion() {
		this.question = ListOfQuestions.questionList [iterate++];
		gameObject.GetComponent<Text>().text = question.getQuestion();
		transform.FindChild ("ChoiceA").FindChild("ChoiceAText").GetComponent<Text>().text = question.getAnswerA();
		transform.FindChild ("ChoiceB").FindChild("ChoiceBText").GetComponent<Text>().text = question.getAnswerB();
		transform.FindChild ("ChoiceC").FindChild("ChoiceCText").GetComponent<Text>().text = question.getAnswerC();
		transform.FindChild ("ChoiceD").FindChild("ChoiceDText").GetComponent<Text>().text = question.getAnswerD();
	}

	public void isAnswerA(){

        if (penalty == true)
        {
            audioSources[1].Play();
            return;
        }
        GameObject settings = GameObject.FindGameObjectWithTag("GameSettings");
        GameSettings script = settings.GetComponent<GameSettings>();
        if ("A" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
            
            
            script.IncreaseScore();
            audioSources[2].Play();
        } else {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = false;
			penalty = true;
            audioSources[1].Play();
            script.Explode();
        }
	}

	public void isAnswerB(){

        if (penalty == true)
        {
            audioSources[1].Play();
            return;
        }
        GameObject settings = GameObject.FindGameObjectWithTag("GameSettings");
        GameSettings script = settings.GetComponent<GameSettings>();
        if ("B" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
            
            script.IncreaseScore();
            audioSources[2].Play();
        } else {
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = false;
			penalty = true;
            audioSources[1].Play();
            script.Explode();
        }
	}

	public void isAnswerC(){

        if (penalty == true)
        {
            audioSources[1].Play();
            return;
        }
        GameObject settings = GameObject.FindGameObjectWithTag("GameSettings");
        GameSettings script = settings.GetComponent<GameSettings>();
        if ("C" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
            
            script.IncreaseScore();
            audioSources[2].Play();
        } else {
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = false;
			penalty = true;
            audioSources[1].Play();
            script.Explode();
        }
	}

	public void isAnswerD(){
        

        if (penalty == true)
        {
            audioSources[1].Play();
            return;
        }
        GameObject settings = GameObject.FindGameObjectWithTag("GameSettings");
        GameSettings script = settings.GetComponent<GameSettings>();
        if ("D" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
            
            script.IncreaseScore();
            audioSources[2].Play();
        } else {
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = false;
			penalty = true;
            audioSources[1].Play();
            script.Explode();
        }
	}
}
