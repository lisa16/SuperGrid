using UnityEngine;
using System.Collections;

public class QuestionClass {
	private string question = null;
	private string answerA = null;
	private string answerB = null;
	private string answerC = null;
	private string answerD = null;
	private string correctAnswer = null;

	public string getQuestion(){
		return question;
	}

	public string getAnswerA(){
		return answerA;
	}

	public string getAnswerB(){
		return answerB;
	}

	public string getAnswerC(){
		return answerC;
	}

	public string getAnswerD(){
		return answerD;
	}

	public string getCorrectAnswer(){
		return correctAnswer;
	}

	public QuestionClass(string Q, string A, string B, string C, string D, string answer){
		this.question = Q;
		this.answerA = A;
		this.answerB = B;
		this.answerC = C;
		this.answerD = D;
		this.correctAnswer = answer;
	}
}