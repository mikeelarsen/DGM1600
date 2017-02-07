using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //In C# there are several different math operators:
            //+, -, *, /, and % are the most common ones. They work as follows:
            //The first four all work the same as they do in standard math.
            //The fifth operator (%) is called a 'modulus' operator.
            //It works like division for integers, but shows only the value of
            //the remainder of the two numbers after division, ie. 16%5 = 1

            int x = 4;
            int y = 2;

            System.Console.WriteLine(x+y);
            //displays 6

            System.Console.WriteLine(x-y);
            //displays 2

            System.Console.WriteLine(x*y);
            //displays 8

            System.Console.WriteLine(x/y);
            //displays 2

            System.Console.WriteLine(x%y);
            //displays 0, because there is no remainder in the division

        //the other types of operators are used to perform basic math operations
        //without writing out lots of code: basically a form of shorthand.
            //+=, -=, *=, /=, %=.

            x += 1;
            //x now equals 5

            x -= 1;
            //x now equals 3

            x *= 1;
            //x still equals 4, since multiplying by 1 doesn't change the value.

            x /= 1;
            //x still equals 4

            x %= 1;
        //x now equals 0 since there is no remainder when dividing by 1.

        //the final types of operators are used to increment and decrement variables
        //both before and after the value is initialized:
            //++, --.

            x++;
            //x is now 5

                System.Console.WriteLine(x++);
                //displays 4 since x will not be incremented until after it's run.

                System.Console.WriteLine(x--);
                //displays 4. After this line, though, x now equals 3.

            ++x;
            //x is now 5

                System.Console.WriteLine(++x);
                //displays 5 since x will be incremented before it's run.

                System.Console.WriteLine(--x);
                //displays 3 since x will be decremented before it's run.

    }

    // Update is called once per frame
    void Update () {
		
	}
}
