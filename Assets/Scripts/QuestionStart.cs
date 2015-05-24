using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class QuestionStart : MonoBehaviour {

	public QuestionClass question;
	private int iterate = 0;

	void Start(){
		ListOfQuestions.setList();
		newQuestion ();
	}
	// Update is called once per frame
	void Update () {
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
		if ("A" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
		} else {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = false;
		}
	}

	public void isAnswerB(){
		if ("B" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
		} else {
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = false;
		}
	}

	public void isAnswerC(){
		if ("C" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
		} else {
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = false;
		}
	}

	public void isAnswerD(){
		if ("D" == this.question.getCorrectAnswer()) {
			transform.FindChild("ChoiceA").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceB").GetComponent<Button>().interactable = true;
			transform.FindChild("ChoiceC").GetComponent<Button>().interactable = true;
			if(iterate < ListOfQuestions.questionList.Length){
				newQuestion();
			}
		} else {
			transform.FindChild("ChoiceD").GetComponent<Button>().interactable = false;
		}
	}
}
