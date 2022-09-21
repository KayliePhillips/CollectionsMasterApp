using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //DONE Create an integer Array of size 50
            int[] myArray1 = new int[50];

            //DONE  Create a method to populate the number array with 50 random numbers that are between 0 and 50
            
            Populater(myArray1);

            //DONE Print the first number of the array

            Console.WriteLine(myArray1[0]);

            //DONE Print the last number of the array            

            Console.WriteLine(myArray1[49]);

            Console.WriteLine("All Numbers Original");
            //DONE   UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray1);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  DONE 1) First way, using a custom method => Hint: Array._____(); 
                DONE 2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(myArray1);
            NumberPrinter(myArray1);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            myArray1 = ReverseArray(myArray1);
            NumberPrinter(myArray1);

            Console.WriteLine("-------------------");

            //DONE Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
           
            Console.WriteLine("Multiple of three = 0: ");
            myArray1 = ThreeKiller(myArray1);
            NumberPrinter(myArray1);

            Console.WriteLine("-------------------");

            //DONE Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray1);
            NumberPrinter(myArray1);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //DONE Create an integer List
            List<int> myList = new List<int>();

            //DONE Print the capacity of the list to the console

            Console.WriteLine(myList.Capacity);

            //DONE: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(myList);

            //DONE: Print the new capacity

            Console.WriteLine(myList.Capacity);

            Console.WriteLine("---------------------");

            //DONECreate a method that prints if a user number is present in the list
            //TODO:  Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var userInput = int.Parse(Console.ReadLine());
            //bool userInput = int.TryParse(Console.ReadLine(), out userInput);
            
            NumberChecker(myList, userInput);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //DONE UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);

            Console.WriteLine("-------------------");


            //DONE: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            myList = OddKiller(myList);
            NumberPrinter(myList);

            Console.WriteLine("------------------");

            //DONE Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter(myList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] array = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            Console.WriteLine(myList.Capacity);
            #endregion
        }

        //DONE Create a method that will set numbers that are a multiple of 3 to zero
        //then print to the console all numbers
        private static int[] ThreeKiller(int[] numbers)
        {
            int[] threeToZero = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
               if (numbers[i]%3==0)
               {
                    threeToZero[i] = 0;
               }
               else
               {
                    threeToZero[i] = numbers[i];
               }
                               
            }
            return threeToZero;
        }

        //DONE Create a method that will remove all odd numbers from the list then print results
        private static List<int> OddKiller(List<int> numberList)
        {
            List<int> evenList = new List<int>();
            foreach (var item in numberList)
            {
                if (item % 2 == 0)
                {
                    evenList.Add(item);
                }
               
            }
            return evenList;
        }

        //DONE Create a method that prints if a user number is present in the list
        //Remember: What if the user types "abc" accident your app should handle that!
        private static void NumberChecker(List<int> numberList, int searchNumber)
        {                  
            if (numberList.Contains(searchNumber))
            {
            Console.WriteLine($"Your number {searchNumber} is in the given number list.");
            }
            else
            {
            Console.WriteLine($"Your number {searchNumber} is NOT in the given number list.");
            }                    
            
        }
        
        //DONE Populate the List with 50 random numbers between 0 and 50 you will need a method for this
        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
            
        }

        //DONE: Create a method to populate the number array with 50 random numbers that are between 0 and 50
        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
            
        }

        //Reverse the contents of the array and then print the array out to the console.
        private static int[] ReverseArray(int[] array) 
        {
            int[] myReverse = new int[array.Length]; 
            for (int i = 0; i < array.Length; i++)
            {
                myReverse[i] = array[array.Length-1-i];
            }
            return myReverse;
        }

        //Methods.ReverseArray(MyArray1));


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
