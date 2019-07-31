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
        static double[] Memory = new double[100];
        
        
        
        //Element of the Memory Array
        static int MemoryElement = 1;

        //The current number is always the last updated element of the Memory array
         static double CurrentNumber;
        //The previous number is always the penultimate updated element of the Memory array
         static double PreviousNumber;

        


        //Convert String to Double
        public static double ConvertStringToDouble(string Number)
        {
            double ConvertedNumber = Convert.ToDouble(Number);

            return ConvertedNumber;
        }

        


       //Calculation part

        public static void GiveBack()
        {
            for(int i = 0; i< Memory.Length; i++)
            {
                Console.WriteLine(Memory[i]);
            }
            
            
        }

        //Addition

            //STOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOP
            //Need to complete this function so that it can infinitely use addition like (3+3+3+3+3 is 15 and not 6 as only the last 2 numbers matter "for now" )
        public static double Addition()
        {
            CurrentNumber = Memory[MemoryElement];
            PreviousNumber = Memory[MemoryElement -1];
            
            MemoryElement += 1;
            return  (CurrentNumber+ PreviousNumber);
        }

        //Subtraction
        public static double Subtraction()
        {
            CurrentNumber = Memory[MemoryElement];
            PreviousNumber = Memory[MemoryElement - 1];
            MemoryElement += 1;
            return (CurrentNumber - PreviousNumber);
        }

        //Division
        public static double Division()
        {
            CurrentNumber = Memory[MemoryElement];
            PreviousNumber = Memory[MemoryElement - 1];
            MemoryElement += 1;
            return (CurrentNumber / PreviousNumber);
        }

        //Multiplication
        public static double Multiplication()
        {
            CurrentNumber = Memory[MemoryElement];
            PreviousNumber = Memory[MemoryElement-1];
            MemoryElement += 1;
            return (CurrentNumber * PreviousNumber);
            
        }

        //Summarize
        //public static double Summarize()
        //{
        //Arra
        //}






        //Memory get/set/clear functions/methods
        
        //Add to Memory array part
        public static void AddToMemory(double Number)
        {
            Memory[MemoryElement] = Number;
            //MemoryElement += 1;
        }

        //Return penultimate value of Memory array
        public static string  ReturnPreviousElementOfMemory()
        {
            return Memory[MemoryElement - 1].ToString();
        }

        //Return next value of Memory array
        public static string ReturnNextElementOfMemory()
        {
            return Memory[MemoryElement + 1].ToString();
        }

        //Clear full Memory array
        public static void ClearFullMemory()
        {
            Array.Clear(Memory, 0, 100);
            MemoryElement = 0;
        }

        //Clear last element of Memory array
        public static void ClearLastElementOfMemory()
        {
            Array.Clear(Memory,MemoryElement ,1);
            MemoryElement -= 1;
        }

    }
}
