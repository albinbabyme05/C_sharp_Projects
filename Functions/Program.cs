using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main()
    {
        string name = "albin";
        int num = 10;

        Assign(ref name,ref num);
        Console.WriteLine(name);
        Console.WriteLine(num);

    }

    static void Assign(ref string nameInput,ref int numInput){
        nameInput = "Unni";
        numInput = 20;
    }
}

