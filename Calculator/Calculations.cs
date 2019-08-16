using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunctions
{
    public static class Calculations
    {
        //The array is used as a memory,so it can be used to check the previous or next element (if there is any)
        //100 because the 0th element is always 0... I used it as I needed a Previous number for the calculations as the index can't be -1
        //There are two STEPS of the array:
        //Step 1: The first number is always 0 or the previous number if the user has already calculated something e.g Memory[0] = 0
        //Step 2: This represents the current number which is in the TbInputNumbers textbox e.g Memory[1] = 50
        //Step 2.1: The calculation will always override the "Current number" as I'm not storing the current number in the Memory array but
        //using it as the previous number every time, instead storing the result like this:
        // e.g: 0+5 = 5; Memory[0] = 0, Memory[1] = 5; 5+5 = 10; 10+5 = 15; Memory[1] = 10, Memory[2] = 15; "5 is always the current number
        //which we are using as an addition"
        static double[] Memory = new double[100];

       
        // Array for the results ONLY
        static double[] ResultMemory = new double[50];
        
        
        
        //Current Element of the Memory Array
        static int MemoryIndex = 1;

        //Current Element of the ResultMemory array
        static int ResultMemoryIndex = 0;

        //Navigator of the ResultMemory array (index but only for navigation)
        //Starts at -1 because we have to increment it by one first
        static int ResultMemoryNavigator = -1;

        

        //The current number is always the last updated element of the Memory array
        static double CurrentNumber;
        //The previous number is always the penultimate updated element of the Memory array
        static double PreviousNumber;

        


      
        //Use it for debugging!
        public static void GiveBackMemoryValues()
        {
            for(int i = 0; i< Memory.Length; i++)
            {
                Console.WriteLine(Memory[i]);
            }
            
        }

        //Use it for debugging!
        public static void GiveBackResultMemoryValues()
        {
            for (int i = 0; i < ResultMemory.Length; i++)
            {
                Console.WriteLine(ResultMemory[i]);
            }

        }

        //Addition
        public static double Addition()
        {
            CurrentNumber = Memory[MemoryIndex];
            PreviousNumber = Memory[MemoryIndex -1];
            
            double Result = PreviousNumber + CurrentNumber;
            
            return  Result;
        }

        //Subtraction
        public static double Subtraction()
        {
            CurrentNumber = Memory[MemoryIndex];
            PreviousNumber = Memory[MemoryIndex - 1];
           

            double Result = PreviousNumber - CurrentNumber;

            
            return Result;
        }


        //Division
        public static double Division()
        {
            CurrentNumber = Memory[MemoryIndex];
            PreviousNumber = Memory[MemoryIndex - 1];
            

            double Result = PreviousNumber / CurrentNumber;

           
            return Result;


            
        }

        //Multiplication
        public static double Multiplication()
        {
            CurrentNumber = Memory[MemoryIndex];
            PreviousNumber = Memory[MemoryIndex-1];
            
            double Result = PreviousNumber * CurrentNumber;

            return Result;
            
            
        }

        //Square
        public static double SquareNumber()
        {
            PreviousNumber = Memory[MemoryIndex - 1];

            double Result = PreviousNumber * PreviousNumber;

            return Result;
        }
        

        public static double SquareRootNumber()
        {
            PreviousNumber = Memory[MemoryIndex - 1];

            double Result = Math.Sqrt(PreviousNumber);

            return Result;
        }



        //Summarize
        public static double Summarize(string MathematicalOperator)
        {
            CurrentNumber = Memory[MemoryIndex];
            PreviousNumber = Memory[MemoryIndex - 1];


            double Result = 0;
            string Operator = MathematicalOperator;

            if (Operator == "+")
            {
                Result = PreviousNumber + CurrentNumber;
            }
            else if (Operator == "-")
            {
                Result = PreviousNumber - CurrentNumber;
            }
            else if (Operator == "/")
            {
                Result = PreviousNumber / CurrentNumber;
            }
            else if (Operator == "*")
            {
                Result = PreviousNumber * CurrentNumber;
            }
            else
                Result = 0;

           

            if (ResultMemoryIndex <= 48)
            {
               
            }


            return Result;
        }

   






        //Memory/ResultMemory get/set/clear functions/methods
        
        //Add to Memory array part
        public static void AddToMemory(double Number)
        {
            Memory[MemoryIndex] = Number;
        }

        //Return penultimate value of Memory array
        public static string  ReturnPreviousElementOfResultMemory()
        {
            return ResultMemory[ResultMemoryIndex - 1].ToString();
        }

        //Return next value of Memory array
        public static string ReturnNextElementOfMemory()
        {
            return ResultMemory[ResultMemoryIndex + 1].ToString();
        }

        //Returns the Previous element of the Memory array
        public static double GiveBackPreviousElementOfMemoryArray()
        {
            return Memory[MemoryIndex - 1];
        }

        //Clear full Memory array
        public static void ClearFullMemory()
        {
            Array.Clear(Memory, 0, 50);
            MemoryIndex = 1;
            
        }

        //Clear last element of Memory array
        public static void ClearLastElementOfMemory()
        {
            Array.Clear(Memory,MemoryIndex ,1);
            MemoryIndex -= 1;
        }

        //Increment memory index by one
        public static void IncrementMemoryIndexByOne()
        {
            MemoryIndex += 1;
        }

        //Add to ResultMemory
        public static void AddToResultMemory(double Number)
        {
            ResultMemory[ResultMemoryIndex] = Number;
        }

        //Increment memory index by one
        public static void IncrementResultMemoryIndexByOne()
        {
            ResultMemoryIndex += 1;
        }

        //Give back the most recently added value of ResultMemory array
        public static double GiveBackMostRecentValueOfResultMemory()
        {
            return ResultMemory[ResultMemoryIndex];
        }





        //Button related functions


        //Delete last letter of a string
        public static string RemoveLastNumberUsedByUser(string CurrentText)
        {
            string AlteredText;

            AlteredText = CurrentText.Remove(CurrentText.Length -1);

            return AlteredText;

            
        }

        //Gives back previous element of Resultmemory
        public static double GiveBackPreviousElementOfResultMemory()
        {
            if (ResultMemoryNavigator > 0)
            {
                return ResultMemory[ResultMemoryNavigator - 1];
            }
            else
                return -9999.6677712;


        }

        //Gives back next element of Resultmemory
        public static double GiveBackNextElementOfResultMemory()
        {
            if (ResultMemoryNavigator < 50)
            {
                return ResultMemory[ResultMemoryNavigator + 1];
            }
            else
                return -9999.6677712;
        }

        //Gives back the value of ResultMemoryNavigator
        public static int GiveBackValueOfResultMemoryNavigator()
        {
            return ResultMemoryNavigator;
        }

        //Increments navigator by one
        public static void IncrementResultMemoryNavigatorByOne()
        {
            ResultMemoryNavigator++;
        }

        //Decrements navigator by one
        public static void DecrementResultMemoryNavigatorByOne()
        {
            ResultMemoryNavigator--;
        }



    }
}
