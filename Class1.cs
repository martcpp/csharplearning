using System;

public class Class1
{
	public Class1()
	{
		/**
		 * basic mathematic operation using csap and variable
		 * 
		 */
		int num1;
		num1 = 5; // this can also be done these way int num1 = 5;

		int num2; // this can also be done these way int num2 = 8;
		num2 = 8;
		// addittion of number
		int add = num1 + num2;
        Console.WriteLine(add);
		// sbstraction of number
		int sub = num1 - num2;
        Console.WriteLine(sub);
		//division of number
		double div = num1 / num2 ;
        Console.WriteLine(div);
		// remainder of number or moldular 
		double mod = num2 % num1;
        Console.WriteLine(mod);

		// inscrement of number
		num1 = num1 + 1;
        Console.WriteLine(num1);
		num1 += num1;
        Console.WriteLine(num1);
		num1++; // post increment
        Console.WriteLine(num1);
		++num1; // pre-increasment
        Console.WriteLine(num1);

		// descreasment of num
		num1 = num1 - 1;
		Console.WriteLine(num1);
		num1 -= num1;
		Console.WriteLine(num1);
		num1--; // post descrement
		Console.WriteLine(num1);
		--num1; // pre-descreasment
		Console.WriteLine(num1);

	}
}
