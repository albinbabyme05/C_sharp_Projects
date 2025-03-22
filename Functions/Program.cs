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

    //========================================================
    /* problem:2  find the index of 'element' from the list */
    //========================================================
    static void Main()
    {
        List<string> shoppingList = new List<string>
        {"milk", "coffee", "cup", "tea"};

        // find the index position of 'coffee' from the list.
        int index = -1; //0-> 

        for(int i=0; i<shoppingList.Count; i++){
            if(shoppingList[i].ToLower().Equals("tea")){
                index = i;
            }
        }
        Console.WriteLine(index>-1 ? "found" : "not found");
        Console.WriteLine("Position: "+index);

    }
}

