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
        //e.g 2+2+2*2 means progress will be 1 as long as we don't get the final result with = sign
        int CalculationIsOnGoing = 0;

        public MainWindow()
        {
            InitializeComponent();
            TbInputNumbers.Text = "0";
            TbMemory.Text = "";
            
            
        }

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

        private void BtnAddition_Click(object sender, RoutedEventArgs e)
        {

            double CurrentNumber = Convert.ToDouble(TbInputNumbers.Text);
            //MessageBox.Show("Current num:" + CurrentNumber);

            Calculations.AddToMemory(CurrentNumber);

            TbMemory.Text = CurrentNumber.ToString();

            double Result = Calculations.Addition();

            TbInputNumbers.Text = Result.ToString();

            //MessageBox.Show(Result.ToString());

            //Calculations.GiveBack();

            CalculationIsOnGoing = 1;

        }
    }
}
