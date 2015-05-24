using UnityEngine;
using System.Collections;

public class ListOfQuestions {

	public static QuestionClass [] questionList;

	public static void setList(){
		questionList = new QuestionClass[]{
			new QuestionClass ("This is Question 1", "Answer 1A", "Answer 1B", "Answer 1C", "Answer 1D", "D"),
			new QuestionClass ("This is Question 2", "Answer 2A", "Answer 2B", "Answer 2C", "Answer 2D", "A"),
			new QuestionClass ("This is Question 3", "Answer 3A", "Answer 3B", "Answer 3C", "Answer 3D", "D"),
			new QuestionClass ("This is Question 4", "Answer 4A", "Answer 4B", "Answer 4C", "Answer 4D", "B"),
			new QuestionClass ("This is Question 5", "Answer 5A", "Answer 5B", "Answer 5C", "Answer 5D", "C"),
			new QuestionClass ("This is Question 6", "Answer 6A", "Answer 6B", "Answer 6C", "Answer 6D", "A"),
			new QuestionClass ("This is Question 7", "Answer 7A", "Answer 7B", "Answer 7C", "Answer 7D", "A"),
			new QuestionClass ("This is Question 8", "Answer 8A", "Answer 8B", "Answer 8C", "Answer 8D", "B"),
			new QuestionClass ("This is Question 9", "Answer 9A", "Answer 9B", "Answer 9C", "Answer 9D", "D"),
			new QuestionClass ("This is Question 10", "Answer 10A", "Answer 10B", "Answer 10C", "Answer 10D", "C")};
	}
}