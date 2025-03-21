using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name : ");
        string? name = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        string? ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);

        Console.WriteLine($"Hi {name}, Your age is {age}");

        if(age >= 18 && age <=25){
            Console.WriteLine("your age in between 18 and 25");
        }else if(age >=25){
            Console.WriteLine("Your age is above 25");
        }else if(age==0 || age<0){
            Console.WriteLine("Invalid Age");
        }else{
            Console.WriteLine("Something went Wrong!");
        }

    }
}
