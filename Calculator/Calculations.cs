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
        //There are three STEPS of the array:
        //Step 1: The first number is always 0 or the previous number if the user has already calculated something e.g Memory[0] = 0
        //Step 2: This represents the current number which is in the TbInputNumbers textbox e.g Memory[1] = 50
        //Step 3: This represents the result after any calculation e.g Memory[2] = 50; why? because 0+50 = 50
        static double[] Memory = new double[100];

       
        // Array for the results ONLY
        static double[] ResultMemory = new double[50];
        
        
        
        //Element of the Memory Array
        static int MemoryIndex = 1;

        //Element of the ResultMemory array
        static int ResultMemoryIndex = 0;

        

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
                Result = -999;

           

            if (ResultMemoryIndex <= 48)
            {
                ResultMemory[ResultMemoryIndex] = Result;
                ResultMemoryIndex += 1;
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

        




       




    }
}
