using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number Coma Separted : ");
        string[] userInputs = (Console.ReadLine()??" ").Split(',');

        //create the List
        List<int> numbersList = new List<int>();

        foreach(string num in userInputs){
            if(int.TryParse(num, out int number)){
                numbersList.Add(number);
            }
        }

        int highestNumber = 0;
        int lowesrNumber = numbersList[0];
        foreach(int currentNumber in numbersList){
            if(currentNumber > highestNumber){
                highestNumber = currentNumber;
            }
            if(currentNumber < lowesrNumber){
                lowesrNumber= currentNumber;
            }
        }
        Console.WriteLine("The Highest Number is: "+highestNumber);
        Console.WriteLine("The Lowest Number is: "+lowesrNumber);
    }
}
