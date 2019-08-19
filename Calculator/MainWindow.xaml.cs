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
    /// 

    public partial class MainWindow : Window
    {

        //0 means new calculations and not in progress
        //e.g 2+2+2*2 means progress will be 1 as long as we don't get the final result
        int CalculationIsOnGoing = 0;

        //Used in a for loop to get the last operator used by the user (BtnSummarize)
        string LastOperatorUsedByUser = "";

        //if this variable is set to 1, then the system will not use the last result in the TbCalculationProgress TextBlock
        bool MemoryHasBeenCleared = false;

        //if this variable is set to true, then the system will wait for a new input before calculating
        //used at the start of Multiplication or Division as 0*9 = 0; 0/9 = error
        bool NewCalculation = true;

        //The current number which is inside the TbInputNumbers textBlock
        double CurrentNumber;

        //The result of any calculation
        double Result;

        //The most recently added result to the ResultMemory Array
        double MostRecentlyAddedResult;

        //as long as the user did not calculate anything or the memory array has just been cleared this variable will stay 0;
        bool NoCalculationsYet = true;

        //The user can only delete the last number if there is no result on the screen, but part of it
        //if the variable is set to true, then the user can't delete the last number he used
        //if the variable is set to false, then the user can delete the last number he used
        bool UserCanDeleteLastNumber = true;



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
               

                //if this is inside the program, then the multiple calculation part does not work
                //Replacing the CurrentNumber part works more effectively and it is easire to understand
                //Calculations.IncrementMemoryIndexByOne();

                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                //Setting the UserCanDelete variable to 0
              
                Result = Calculations.Addition();
                Math.Round(Result, 10);

                TbResultMemory.Text = Result.ToString();

                Calculations.AddToMemory(Result);
                Calculations.IncrementMemoryIndexByOne();

                //Setting this variable to false as the user can use division or multiplication, because the Memory array is not empty
                NewCalculation = false;

                NoCalculationsYet = false;

            }
            if (TbInputNumbers.Text == "0")
            {
                MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == true)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = false;
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
            //Incrementing MemoryIndex by one
            //Storing the calculation in the result variable (Rounding the result)
            //Adding result to Memory and ResultMemory
            //Incrementing the navigator by one and setting the navigator on this side to the new value
            //User cannot delete last number of the result, setting NoCalculationsYet to false as we've just calculated

            CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);

            Calculations.AddToMemory(CurrentNumber);
            Result = Calculations.Summarize(LastOperatorUsedByUser);
            Calculations.IncrementMemoryIndexByOne();
            Math.Round(Result, 10);

            Calculations.AddToMemory(Result);
            Calculations.AddToResultMemory(Result);
            Calculations.IncrementResultMemoryIndexByOne();
            Calculations.GiveBackResultMemoryValues();

            Calculations.IncrementResultMemoryNavigatorByOne();

            UserCanDeleteLastNumber = true;
            NoCalculationsYet = false;

            //Setting this variable to false as the user can use division or multiplication, because the Memory array is not empty
            NewCalculation = false;

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

            MemoryHasBeenCleared = true;
            NoCalculationsYet = true;
            UserCanDeleteLastNumber = true;
            NewCalculation = true;


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

                //if this is inside the program, then the multiple calculation part does not work
                //Replacing the CurrentNumber part works more effectively and it is easire to understand
                //Calculations.IncrementMemoryIndexByOne();

                //Checking if there is a new calculation in progress or not
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one

                Result = Calculations.Subtraction();
                Math.Round(Result, 10);

                TbResultMemory.Text = Result.ToString();

                Calculations.AddToMemory(Result);
                Calculations.IncrementMemoryIndexByOne();

                UserCanDeleteLastNumber = false;

                //Setting this variable to false as the user can use division or multiplication, because the Memory array is not empty
                NewCalculation = false;


            }
            else if (TbInputNumbers.Text == "0")
            {
                MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == true)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = false;
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

                if (NewCalculation == true)
                {
                    //Converting the Current number which is inside the TbInputNumbers TextBlock
                    //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                    CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
                    Calculations.AddToMemory(CurrentNumber);
                    Calculations.IncrementMemoryIndexByOne();


                    UserCanDeleteLastNumber = true;

                }


                //if this is inside the program, then the multiple calculation part does not work
                //Replacing the CurrentNumber part works more effectively and it is easire to understand
                //Calculations.IncrementMemoryIndexByOne();


                //Checking if there is a new calculation in progress or not
                //Converting the Current number which is inside the TbInputNumbers TextBlock
                //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                if (NewCalculation == false)
                {

                    CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
                    Calculations.AddToMemory(CurrentNumber);

                    Result = Calculations.Multiplication();
                    Math.Round(Result, 10);

                    TbResultMemory.Text = Result.ToString();

                    Calculations.AddToMemory(Result);
                    Calculations.IncrementMemoryIndexByOne();

                    NewCalculation = true;
                    UserCanDeleteLastNumber = false;
                }
            }
            else if (TbInputNumbers.Text == "0")
            {
                double MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == true)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = false;
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

                if (NewCalculation == true)
                {
                    //Converting the Current number which is inside the TbInputNumbers TextBlock
                    //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                    CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
                    Calculations.AddToMemory(CurrentNumber);
                    Calculations.IncrementMemoryIndexByOne();

                    
                    UserCanDeleteLastNumber = true;

                }


                //if this is inside the program, then the multiple calculation part does not work
                //Replacing the CurrentNumber part works more effectively and it is easire to understand
                //Calculations.IncrementMemoryIndexByOne();


                //Checking if there is a new calculation in progress or not
                //Converting the Current number which is inside the TbInputNumbers TextBlock
                //Adding the Current number to the Memory array, incrementing the Memory array's index counter by one
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                if (NewCalculation == false)
                {
                   
                    CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
                    Calculations.AddToMemory(CurrentNumber);

                    Result = Calculations.Division();
                    Math.Round(Result, 10);

                    TbResultMemory.Text = Result.ToString();

                    Calculations.AddToMemory(Result);
                    Calculations.IncrementMemoryIndexByOne();

                    NewCalculation = true;
                    UserCanDeleteLastNumber = false;
                }


            }
            else if (TbInputNumbers.Text == "0")
            {
                double MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();


                //Checking whether the memory has been cleared or not
                //Progress of the calculation's text
                if (MemoryHasBeenCleared == true)
                {
                    TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();
                    MemoryHasBeenCleared = false;
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

            if (NoCalculationsYet == true)
            {
                //Converting the Current number which is inside the TbInputNumbers TextBlock
                //Adding the Current number to the Memory array,Incrementing the MemoryIndex by one
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //We add the button's text to the TbCalculationProgress textblock 
                //Adding the result to the Memory array and ResultMemory array
                //incrementing the Memory array's and ResultMemory array's index counter by one
                //Incrementing the navigator by one and setting the navigator on this side to the new value

                double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();

                double Result = Calculations.SquareNumber();
                Math.Round(Result, 10);

                TbResultMemory.Text = Result.ToString();
                TbCalculationProgress.Text = "(" + CurrentNumber + " * " + CurrentNumber + ")";

                Calculations.AddToMemory(Result);
                Calculations.AddToResultMemory(Result);
                Calculations.IncrementResultMemoryIndexByOne();
                
                Calculations.IncrementResultMemoryNavigatorByOne();

                //Setting the NoCalculationsYet variable to false as we've just calculated the result
                NoCalculationsYet = false;


            }
            else if (NoCalculationsYet == false)
            {
                //Storing the previous element of the Memory array in the Previous number variable
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //We add the button's text to the TbCalculationProgress textblock 
                //Adding the result to the Memory array and ResultMemory array
                //incrementing the Memory array's and ResultMemory array's index counter by one
                //Incrementing the navigator by one and setting the navigator on this side to the new value

                Calculations.IncrementMemoryIndexByOne();
                double PreviousNumber = 0;
                double ExceptionValue = -9999.6677712;
                if (Calculations.GiveBackPreviousElementOfMemoryArray() != ExceptionValue)
                {
                    PreviousNumber = Calculations.GiveBackPreviousElementOfMemoryArray();
                }
                double Result = Calculations.SquareNumber();
                Math.Round(Result, 10);

                TbResultMemory.Text = Result.ToString();
                TbCalculationProgress.Text = "(" + PreviousNumber + " * " + PreviousNumber + ")";

                Calculations.AddToMemory(Result);
                
                Calculations.AddToResultMemory(Result);
                Calculations.IncrementResultMemoryIndexByOne();

                Calculations.IncrementResultMemoryNavigatorByOne();
               

            }

            //Setting this variable to false as the user can use division or multiplication, because the Memory array is not empty
            NewCalculation = false;

            //Setting the UserCanDeleteLastNumber variable to false as the user cannot Delete back from the result
            UserCanDeleteLastNumber = false;

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";

        }

        //button √ 
        private void BtnSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            if (NoCalculationsYet == true)
            {
                //Converting the Current number which is inside the TbInputNumbers TextBlock
                //Adding the Current number to the Memory array,Incrementing the MemoryIndex by one
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //We add the button's text to the TbCalculationProgress textblock 
                //Adding the result to the Memory array and ResultMemory array
                //incrementing the Memory array's and ResultMemory array's index counter by one
                //Incrementing the navigator by one and setting the navigator on this side to the new value

                double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
                Calculations.AddToMemory(CurrentNumber);
                Calculations.IncrementMemoryIndexByOne();

                double Result = Calculations.SquareRootNumber();
                Math.Round(Result, 10);

                TbResultMemory.Text = Result.ToString();
                TbCalculationProgress.Text = "√" + CurrentNumber + "";

                Calculations.AddToMemory(Result);
                
                Calculations.AddToResultMemory(Result);
                Calculations.IncrementResultMemoryIndexByOne();

                Calculations.IncrementResultMemoryNavigatorByOne();
                

                //Setting the NoCalculationsYet variable to false as we've just calculated the result
                NoCalculationsYet = false;


            }
            else if (NoCalculationsYet == false)
            {
                //Storing the previous element of the Memory array in the Previous number variable
                //Storing the calculation in the result variable (Rounding the result)
                //Showing the user the given result in the TbResultmemory textBlock
                //We add the button's text to the TbCalculationProgress textblock 
                //Adding the result to the Memory array and ResultMemory array
                //incrementing the Memory array's and ResultMemory array's index counter by one
                //Incrementing the navigator by one and setting the navigator on this side to the new value

                Calculations.IncrementMemoryIndexByOne();
                double PreviousNumber = Calculations.GiveBackPreviousElementOfMemoryArray();
                double Result = Calculations.SquareRootNumber();
                Math.Round(Result, 10);

                TbResultMemory.Text = Result.ToString();
                TbCalculationProgress.Text = "(" + PreviousNumber + " * " + PreviousNumber + ")";

                Calculations.AddToMemory(Result);
                
                Calculations.AddToResultMemory(Result);
                Calculations.IncrementResultMemoryIndexByOne();

                Calculations.IncrementResultMemoryNavigatorByOne();
                
            }

            //Setting the UserCanDeleteLastNumber variable to false as the user cannot Delete back from the result
            UserCanDeleteLastNumber = false;

            //Setting this variable to false as the user can use division or multiplication, because the Memory array is not empty
            NewCalculation = false;

            //After the calculation this variable will always be one
            CalculationIsOnGoing = 1;

            //Setting the TbInputNumbers Textblock's text to default after every calculation
            TbInputNumbers.Text = "0";
        }

        //Button <--
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            string CurrentText = TbInputNumbers.Text;
            
            if(UserCanDeleteLastNumber == true && CurrentText.Length > 1)
            {
                TbInputNumbers.Text = Calculations.RemoveLastNumberUsedByUser(CurrentText);
            }


        }

        //Point
        private void BtnPoint_Click(object sender, RoutedEventArgs e)
        {
            bool NoPeriodInTheText = true;

            string CurrentInputNumbers = TbInputNumbers.Text;

            if(CurrentInputNumbers.Contains("."))
            {
                NoPeriodInTheText = false;
            }
            

            if(NoPeriodInTheText == true )
            {
                TbInputNumbers.Text += ",";
            }
            
        }
        //Change current text to minus or positive
        private void BtnChangePlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if(UserCanDeleteLastNumber == true)
            {
                string MinusOperator = "-";
                string ZeroString = "0";

                int Positive = 1;
                int Negative = -1;
                int Zero = 0;

                int NumberIs = Positive;


                //Had to convert the CurrentNumber to a double, otherwise the NumberIs Variable would stay on Positive forever
                //Why? Because I checked whether the 0th element of the CurrentInputNumbers variable
                //was not equal (!=) to the MinusOperator variable
                string CurrentInputNumbers = TbInputNumbers.Text;
                double ConvertedCurrentNumber = Convert.ToDouble(CurrentInputNumbers);

                if (ConvertedCurrentNumber > 0)
                {
                    NumberIs = Positive;
                }
                else if (CurrentInputNumbers[0].ToString() == MinusOperator)
                {
                    NumberIs = Negative;
                }
                else if (CurrentInputNumbers == ZeroString)
                {
                    NumberIs = Zero;
                }


                string ReplacedInputNumbers;

                if (NumberIs == Positive)
                {
                    ReplacedInputNumbers = MinusOperator + CurrentInputNumbers;
                    TbInputNumbers.Text = ReplacedInputNumbers;
                    UserCanDeleteLastNumber = false;
                }
                else if (NumberIs == Negative)
                {
                    ReplacedInputNumbers = CurrentInputNumbers.Remove(0, 1);
                    TbInputNumbers.Text = ReplacedInputNumbers;
                    UserCanDeleteLastNumber = false;
                }
                else if (NumberIs == Zero)
                {
                    ReplacedInputNumbers = CurrentInputNumbers;
                    TbInputNumbers.Text = ReplacedInputNumbers;
                    UserCanDeleteLastNumber = false;
                }
            }
         

        }

        //Button CE
        private void BtnClearLast_Click(object sender, RoutedEventArgs e)
        {
            TbInputNumbers.Text = "0";
        }

        //Button <<
        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        { 
            double PreviousResult = Calculations.GiveBackPreviousElementOfResultMemory();

            double ExceptionValue = -9999.6677712;

            if (PreviousResult != ExceptionValue && PreviousResult != 0 )
            {
                TbResultMemory.Text = PreviousResult.ToString();
                Calculations.DecrementResultMemoryNavigatorByOne();
            }
        }

        //Button >>
        private void BtnNextResult_Click(object sender, RoutedEventArgs e)
        {
            double NextResult = Calculations.GiveBackNextElementOfResultMemory();

            double ExceptionValue = -9999.6677712;

            if (NextResult != ExceptionValue && NextResult != 0)
            {
                TbResultMemory.Text = NextResult.ToString();
                Calculations.IncrementResultMemoryNavigatorByOne();
                
            }
        }
    }
}
