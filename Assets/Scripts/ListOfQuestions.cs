using UnityEngine;
using System.Collections;

public class ListOfQuestions {
	public static QuestionClass [] questionList;
	public static void setList(){
		questionList = new QuestionClass[]{
			new QuestionClass ("Which resistor would produce 50mA of current with 50V battery in a series circuit?", "Answer 100Ω resistor", "Answer 500Ω resistor", "Answer 10Ω resistor", "Answer 1000Ω resistor", "D"),
			new QuestionClass ("What is the voltage of a series circuit with 50Ω resistor with 25A current?", "Answer 1250V", "Answer 2V", "Answer 0.5V", "Answer 125V", "A"),
			new QuestionClass ("Which resistor would produce 7.5A of current with 75V battery in a series circuit?", "Answer 75Ω resistor", "Answer 750Ω resistor", "Answer 0.1Ω resistor", "Answer 10Ω resistor", "D"),
			new QuestionClass ("What is the current of a series ciruit with 561 540V battery and 420Ω resistor", "Answer 1320A", "Answer 1337A", "Answer 523 402mA", "Answer 9999A", "B"),
			new QuestionClass ("What is the current of a series ciruit with 9999V battery and 9Ω resistor", "Answer 11mA", "Answer 99A", "Answer 1111A", "Answer 10A", "C"),
			new QuestionClass ("What is the voltage of a series circuit with 1kΩ resistor with 123A current?", "Answer 123kV", "Answer 1230V", "Answer 1kV", "Answer 1400V", "A"),
			new QuestionClass ("Which resistor would produce 1mA of current with 1000V battery in a series circuit?", "Answer 1 000 000Ω resistor", "Answer 0.0001Ω resistor", "Answer 1010Ω resistor", "Answer 1000Ω resistor", "A"),
			new QuestionClass ("What is the voltage of a series circuit with 7Ω resistor with 48A current?", "Answer 286mV", "Answer 336V", "Answer 286V", "Answer 316V", "B"),
			new QuestionClass ("What is the current of a series ciruit with 10 101 010V battery and 1010Ω resistor", "Answer 1111A", "Answer 10 000A", "Answer 1010mA", "Answer 10 001A", "D"),
			new QuestionClass ("Which resistor would produce 1A of current with 1V battery in a series circuit?", "Answer 100Ω resistor", "Answer 10Ω resistor", "Answer 1Ω resistor", "Answer 1000Ω resistor", "C")};
	}
}