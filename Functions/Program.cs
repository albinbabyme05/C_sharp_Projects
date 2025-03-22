using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

    //========================================================
    /* problem:2  find the index of 'element' from the list using function*/
    //========================================================

    static void Main(){
        List<string> shoppingList = new List<string>
        {"milk", "coffee", "cup", "tea"};


        FindInList("cup", shoppingList, out int index);
        Console.WriteLine("position : "+index);
        // or you can write
        Console.WriteLine("index position: "+shoppingList.IndexOf("milk"));
        
    }

    /*here  we use 'out' in the function which returns a bool
    and value and value can be used by using 'out int variable name'
    */
    static bool FindInList(string s, List<string> shopList, out int index){
        index = -1;
        for(int i=0; i<shopList.Count; i++){
            if(shopList[i].ToLower().Equals(s.ToLower())){
                index = i;
            }
        }
        bool found = index>-1; //-1 indecated not fond the element form the list
        return found;

    }
    //=======================================================================
    //=======================================================================

    /*ask user to enter width and height and store them
    *calc the area  in the funtion 
    *call in main and display out
    */

    static void Main(){
        
        int height = ConvertToInt("Enter height : ");
        int width =  ConvertToInt("Enter height : ");

        float area = CalcArea(height, width);

        Console.WriteLine($"Area of the given Triangle is {area}");

    }

    static int CalcArea(int height, int width){
        return (height*width)/2;
    }

    static int ConvertToInt(string message){
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
}

