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
    public partial class MainWindow : Window
    {

        //0 means new calculations and not in progress
        //e.g 2+2+2*2 means progress will be 1 as long as we don't get the final result
        int CalculationIsOnGoing = 0;

        //Used in a for loop to get the last operator used by the user
        string LastOperatorUsedByUser = "";


        //After using any button the system must wait for another input first and only then calculate the result
        //e.g 2+2 = 4 but if we click on the + button again then it will automatically calculate the result
        //so it will be 4+2 and not (4 + NUMBER GIVEN BY USER)
      

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
                double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);

                //Adding the Current number to the Memory array
                Calculations.AddToMemory(CurrentNumber);

                //Storing the calculation in the result variable, Incrementing the Memory array's index counter by one
                //Showing the user the given result in the TbInputNumbers textBlock
                //Adding the result to the Memory array, incrementing the Memory array's index counter by one
                double Result = Calculations.Addition();
                Calculations.IncrementMemoryIndexByOne();
                TbInputNumbers.Text = Result.ToString();
                Calculations.AddToMemory(Result);
                Calculations.IncrementMemoryIndexByOne();
               
            }
            else if(TbInputNumbers.Text == "0")
            {
                double MostRecentlyAddedResult = Calculations.GiveBackMostRecentValueOfResultMemory();
                

                //Progress of the calculation's text
                TbCalculationProgress.Text += MostRecentlyAddedResult.ToString();


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
            //Storing the calculation in the result variable,
            double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
            Calculations.AddToMemory(CurrentNumber);
            double Result = Calculations.Summarize(LastOperatorUsedByUser);
            Calculations.AddToMemory(Result);
            Calculations.AddToResultMemory(Result);

            //Setting the InputNumbers and ResultMemory textblocks's text to the result
            TbInputNumbers.Text = Result.ToString();
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
            Calculations.GiveBackMemoryValues();

        }
    }
}
