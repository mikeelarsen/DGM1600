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

		var exampleString = "Hello, world.";
		var exampleInt = 8;
		var exampleDouble = 55.02;
		var printTheSamples = true;

		if(printTheSamples = true){
			System.Console.WriteLine (exampleInt);
			System.Console.WriteLine (exampleString);
			System.Console.WriteLine (exampleDouble);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
