using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//a variable works just like it does in algebra, that is, it stores something for use later.
		//in C# code, variables must be declared with the "var" keyword and ended with a semicolon.
		//a variable is like a container for a specific type of data. In C#, these data types include:
			//strings (words, sentences, etc.), integers (whole numbers), doubles (decimal numbers 64bit),
			//booleans (true or false), and floats (decimal values 32bit).
		//Here are some examples of declared variables:

		string exampleString = "Hello, world.";
		int exampleInt = 8;
		double exampleDouble = 55.02;
		float exampleFloat = 4.61;
		bool printTheSamples = true;
		var myVariable;

		if(printTheSamples = true){
			System.Console.WriteLine (exampleInt);
			System.Console.WriteLine (exampleString);
			System.Console.WriteLine (exampleDouble);
			System.Console.WriteLine (exampleFloat);

			myVariable = "this is my variable now";
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
