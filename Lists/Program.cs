using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number separted by comma ! \n");
        string[] inputs = (Console.ReadLine()??"").Split(',');

        List<int> numbers = new List<int>();

        foreach(string num in inputs){
            if(int.TryParse(num, out int number)){
                numbers.Add(number);
            }
        }
        
        int sum = 0;
        foreach(int num in numbers){
            sum += num;
        }
        Console.WriteLine("The sum of all number in the List is "+sum);

    }
}

