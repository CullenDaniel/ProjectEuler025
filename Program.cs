/*****
 * Daniel Cullen
 * DanCullen@live.com or Cullendl@mail.uc.edu
 * This is the solution to ProjectEuler number 025
 * https://projecteuler.net/problem=25
 **/
using System;
using System.Collections;
using System.Numerics;

namespace ProjectEuler025
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigInteger firstValue = new BigInteger(1); //Creates the first value
            BigInteger secondValue = new BigInteger(1); //Creates the second value value
            int maxNumberLength = 1000; //Creates the max length of the number

            ArrayList loopSize = new ArrayList(); //Creates an array list to track the amount of terms

            Console.WriteLine("firstValue is>" + firstValue + "<"); //shows for readability

            Console.WriteLine("secondValue is>" + secondValue + "<"); //shows for readability
            loopSize.Add(firstValue);
            loopSize.Add(secondValue); 
            Console.WriteLine("It is term " + loopSize.Count); //shows for the term count

            while (firstValue.ToString().Length < maxNumberLength && secondValue.ToString().Length < maxNumberLength) //iterates through the loop until the target length is reached
            {
                firstValue = firstValue + secondValue; //adds the "second" value to the first
                secondValue = firstValue + secondValue; //adds the "first" value to the second
                Console.WriteLine("firstValue is >" + firstValue + "<"); //shows for readability
                loopSize.Add(firstValue); 
                Console.WriteLine("firstValue length >" + firstValue.ToString().Length + "<"); //shows for checking current length
                Console.WriteLine("It is term " + loopSize.Count); //shows for the term count
                Console.WriteLine("secondValue is >" + secondValue + "<"); //shows for readability
                loopSize.Add(secondValue);
                Console.WriteLine("secondValue length >" + secondValue.ToString().Length + "<"); //shows for checking current length
                Console.WriteLine("It is term " + loopSize.Count); //shows for the term count

            }

        }
    }
}
