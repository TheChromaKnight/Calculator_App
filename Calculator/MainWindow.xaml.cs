using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalculatorFunctions;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// What if I used the nocalculationsyet variable to fix the wrong calculations 

    public partial class MainWindow : Window
    {

        //0 means new calculations and not in progress
        //e.g 2+2+2*2 means progress will be 1 as long as we don't get the final result
        int CalculationIsOnGoing = 0;

        //Used in a for loop to get the last operator used by the user
        string LastOperatorUsedByUser = "";

        //if this variable is set to 1, then the system will not use the last result in the TbCalculationProgress TextBlock
        int MemoryHasBeenCleared = 0;

        //if this variable is set to 1, then the system will wait for a new input before calculating
        //used at the start of Multiplication or Division as 0*9 = 0; 0/9 = error
        int NewCalculation = 1;

        //The current number which is inside the TbInputNumbers textBlock
        double CurrentNumber;

        //The result of any calculation
        double Result;

        //The most recently added result to the ResultMemory Array
        double MostRecentlyAddedResult;

        //as long as the user did not calculate anything or the memory array has just been cleared this variable will stay 0;
        int NoCalculationsYet = 0;

        //This variable represents 2 states:
        //if the variable is set to 0, then the user can't delete the last number he used
        //if the variable is set to 1, then the user can delete the last number he used
        //The user can only delete the last number if there is no result on the screen, but part of it
        int UserCanDeleteLastNumber = 1;




        public MainWindow()
        {
            InitializeComponent();
            TbInputNumbers.Text = "0";
            TbResultMemory.Text = "";
            TbCalculationProgress.Text = "";
            
            
        }






        //Buttons

        //button 0
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            


            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "0";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "0";
            
           
        }

        //button 1
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            
            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "1";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "1";
        }

        //button 2
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "2";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "2";
        }

        //button 3
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
           

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "3";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "3";
        }

        //button 4
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
           

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "4";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "5";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "5";
        }

        //button 6
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
           

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "6";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "6";
        }

        //button 7
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            
            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "7";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "7";
        }

        //button 8
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
           

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "8";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "8";
        }

        //button 9
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
           

            if (TbInputNumbers.Text == "0" || CalculationIsOnGoing == 1)
            {
                TbInputNumbers.Text = "9";
                CalculationIsOnGoing = 0;
            }
            else if (TbInputNumbers.Text.Length == 10)
            {

            }
            else
                TbInputNumbers.Text += "9";
        }

        
        //button +
        private void BtnAddition_Click(object sender, RoutedEventArgs e)
        {
            if (TbInputNumbers.Text != "0")
            {
                //Progress of the calculation's text
                TbCalculationProgress.Text += TbInputNumbers.Text;


                //Converting the Current number which is inside the TbInputNumbers TextBlock
                CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);


                //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();

                //Checking if there is a new calculation in progress or not
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                //Setting the UserCanDelete variable to 0
              
                Result = Calculations.Addition();
                Math.Round(Result, 10);
                TbResultMemory.Text = Result.ToString();
                Calculations.AddToMemory(Result);
                Calculations.IncrementMemoryIndexByOne();
                
                    
            }
            else if (TbInputNumbers.Text == "0")
            {
                MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == 1)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = 0;
                }


                //Increment the index by one as we are not calculating but waiting for a new input
                //(if this is not here then the result STEP of the Memory array will always change to the new input)
                Calculations.IncrementMemoryIndexByOne();
            }


            //We add the button's text to the TbCalculationProgress textblock 
            TbCalculationProgress.Text += "+";

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        //Button =
        private void BtnSummarize_Click(object sender, RoutedEventArgs e)
        {
            //We add the button's text to the TbCalculationProgress textblock 
            TbCalculationProgress.Text += "=";


            //The most recently used operator is required for the right calculation method
            string CalculationProgress = TbCalculationProgress.Text;

            for(int i = 0; i<CalculationProgress.Length; i++)
            {
                if(CalculationProgress[i].ToString() == "+")
                {
                    LastOperatorUsedByUser = "+";
                }
                else if (CalculationProgress[i].ToString() == "-")
                {
                    LastOperatorUsedByUser = "-";
                }
                else if (CalculationProgress[i].ToString() == "/")
                {
                    LastOperatorUsedByUser = "/";
                }
                else if (CalculationProgress[i].ToString() == "*")
                {
                    LastOperatorUsedByUser = "*";
                }
            }

            //Storing the current number which is inside the tbINputNumbers textblock,Adding current number to Memory array
            //Storing the calculation in the result variable (Rounding the result)
            //User cannot delete last number of the result
            CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
            Calculations.AddToMemory(CurrentNumber);
            Result = Calculations.Summarize(LastOperatorUsedByUser);
            Calculations.IncrementMemoryIndexByOne();
            Math.Round(Result, 10);
            Calculations.AddToMemory(Result);
            Calculations.AddToResultMemory(Result);
            UserCanDeleteLastNumber = 0;

            //Setting the ResultMemory textblocks's text to the result

            TbResultMemory.Text = Result.ToString();

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbCalculationProgress's text to default
            TbCalculationProgress.Text = "";

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";

        }

        private void BtnClearAll_Click(object sender, RoutedEventArgs e)
        {
            Calculations.ClearFullMemory();
            TbCalculationProgress.Text = "";
            TbInputNumbers.Text = "0";
            TbResultMemory.Text = "";

            MemoryHasBeenCleared = 1;
            NoCalculationsYet = 0;


        }


        //button -
        private void BtnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (TbInputNumbers.Text != "0")
            {
                //Progress of the calculation's text
                TbCalculationProgress.Text += TbInputNumbers.Text;


                //Converting the Current number which is inside the TbInputNumbers TextBlock
                CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);



                //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();

                //Checking if there is a new calculation in progress or not
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
               
                    Result = Calculations.Subtraction();
                    Math.Round(Result, 10);
                    TbResultMemory.Text = Result.ToString();
                    Calculations.AddToMemory(Result);
                    Calculations.IncrementMemoryIndexByOne();
                 

            }
            else if (TbInputNumbers.Text == "0")
            {
                MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == 1)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = 0;
                }


                //Increment the index by one as we are not calculating but waiting for a new input
                //(if this is not here then the result STEP of the Memory array will always change to the new input)
                Calculations.IncrementMemoryIndexByOne();
            }
            

            //We add the button's text to the TbCalculationProgress textblock 
            TbCalculationProgress.Text += "-";

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        //button X
        private void BtnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            if (TbInputNumbers.Text != "0")
            {
                //Progress of the calculation's text
                TbCalculationProgress.Text += TbInputNumbers.Text;


                //Converting the Current number which is inside the TbInputNumbers TextBlock
                CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);



                //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();

                //Checking if there is a new calculation in progress or not
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                if (NewCalculation == 0)
                {
                    Result = Calculations.Multiplication();
                    Math.Round(Result, 10);
                    TbResultMemory.Text = Result.ToString();
                    Calculations.AddToMemory(Result);
                    Calculations.IncrementMemoryIndexByOne();
                    NewCalculation = 1;
                }
           

            }
            else if (TbInputNumbers.Text == "0")
            {
                double MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == 1)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = 0;
                }


                //Increment the index by one as we are not calculating but waiting for a new input
                //(if this is not here then the result STEP of the Memory array will always change to the new input)
                Calculations.IncrementMemoryIndexByOne();
            }

            //We add the button's text to the TbCalculationProgress textblock 
            TbCalculationProgress.Text += "*";

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        // Button /
        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            if (TbInputNumbers.Text != "0")
            {
                //Progress of the calculation's text
                TbCalculationProgress.Text += TbInputNumbers.Text;


                //Converting the Current number which is inside the TbInputNumbers TextBlock
                CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);



                //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();

                //Checking if there is a new calculation in progress or not
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                if (NewCalculation == 0)
                {
                    Result = Calculations.Division();
                    Math.Round(Result, 10);
                    TbResultMemory.Text = Result.ToString();
                    Calculations.AddToMemory(Result);
                    Calculations.IncrementMemoryIndexByOne();
                    NewCalculation = 1;
                }


            }
            else if (TbInputNumbers.Text == "0")
            {
                double MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == 1)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = 0;
                }


                //Increment the index by one as we are not calculating but waiting for a new input
                //(if this is not here then the result STEP of the Memory array will always change to the new input)
                Calculations.IncrementMemoryIndexByOne();
            }

            //We add the button's text to the TbCalculationProgress textblock 
            TbCalculationProgress.Text += "/";

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        //button x2
        private void BtnSquared_Click(object sender, RoutedEventArgs e)
        {

            
            //Use it as a Memory array filling phase, as we can't calculate with the -1th element of the array
            if (NoCalculationsYet == 0)
            {
                //Converting the Current number which is inside the TbInputNumbers TextBlock
                double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);

                //We add the button's text to the TbCalculationProgress textblock 
                TbCalculationProgress.Text = "Sqr( " + CurrentNumber + " )";


                //Adding the Current number to the Memory array,Incrementing the MemoryIndex by one
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();
                NoCalculationsYet = 1;
                UserCanDeleteLastNumber = 0;

            }


            //Storing the calculation in the result variable (Rounding the result)
            //Showing the user the given result in the TbResultmemory textBlock
            //Adding the result to the Memory array and ResultMemory array
            //incrementing the Memory array's and ResultMemory array's index counter by one
            double Result = Calculations.SquareNumber();
            Math.Round(Result, 10);
            TbResultMemory.Text = Result.ToString();
            Calculations.AddToMemory(Result);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToResultMemory(Result);
            Calculations.IncrementResultMemoryIndexByOne();

           

           
            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        //button √ 
        private void BtnSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            //Progress of the calculation's text
            TbCalculationProgress.Text += TbInputNumbers.Text;

            //Use it as a Memory array filling phase, as we can't calculate with the -1th element of the array
            if (NoCalculationsYet == 0)
            {
                //Converting the Current number which is inside the TbInputNumbers TextBlock
                double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);


                //Adding the Current number to the Memory array,Incrementing the MemoryIndex by one
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();
                NoCalculationsYet = 1;
                UserCanDeleteLastNumber = 0;

            }


            //Storing the calculation in the result variable (Rounding the result)
            //Showing the user the given result in the TbResultmemory textBlock
            //Adding the result to the Memory array and ResultMemory array
            //incrementing the Memory array's and ResultMemory array's index counter by one
            double Result = Calculations.SquareRootNumber();
            Math.Round(Result, 10);
            
            TbResultMemory.Text = Result.ToString();
            Calculations.AddToMemory(Result);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToResultMemory(Result);
            Calculations.IncrementResultMemoryIndexByOne();

            //We add the button's text to the TbCalculationProgress textblock 
            TbCalculationProgress.Text = "√( " + CurrentNumber + " )";


            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        //Button <--
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            string CurrentText = TbInputNumbers.Text;
            
            if(UserCanDeleteLastNumber == 1 && CurrentText.Length > 1)
            {
                TbInputNumbers.Text = Calculations.RemoveLastNumberUsedByUser(CurrentText);
            }


        }
    }
}
