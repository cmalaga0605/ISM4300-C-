using System;

namespace Class_Project___Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try                                                      //try portion to catch exceptions 
            {
                int x = 25;                                          //declared variable x and set it equal to int 25
                int[] myArray = new int[x];                          //declared an array 
                for(int index = 0; index < x; index++)               // used a for loop to add subscripts to the elements 
                {
                    myArray[index]= 99;                              //set all the array subscripts equal to 99 
                    Console.WriteLine("Element value =  " + index);  //printed the sting with the element
                }
                


            }
            catch                                                 //catch portion to catch exceptions 
            {
                Console.WriteLine("There is an Exception.. ");    //printed the string for any exception
            }
        }
    }
}
