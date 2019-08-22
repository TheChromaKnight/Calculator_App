using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorFunctions;


namespace Calculator_UnitTests
{
    [TestClass]
    public class CalculationsTests
    {
        [TestMethod]
        public void Addition_NumbersAre5_CalculatesCorrectly()
        {
            //Arrange
            Calculations.AddToMemory(5);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(5);

            //Act
            double Result = Calculations.Addition();
            double ExpectedResult = 10;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Subtraction_NumbersAre15And5_CalculatesCorrectly()
        {
            //Arrange
            Calculations.AddToMemory(15);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(5);

            //Act
            double Result = Calculations.Subtraction();
            double ExpectedResult = 10;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Multiplication_NumbersAre5And2_CalculatesCorrectly()
        {
            //Arrange
            Calculations.AddToMemory(5);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(2);

            //Act
            double Result = Calculations.Multiplication();
            double ExpectedResult = 10;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Division_NumbersAre20And2_CalculatesCorrectly()
        {
            //Arrange
            Calculations.AddToMemory(20);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(2);

            //Act
            double Result = Calculations.Division();
            double ExpectedResult = 10;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void SquareNumber_Numberis4_CalculatesCorrectly()
        {
            //Arrange
            Calculations.AddToMemory(4);
            Calculations.IncrementMemoryIndexByOne();

            //Act
            double Result = Calculations.SquareNumber();
            double ExpectedResult = 16;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void SquareRootNumber_NumberIs9_CalculatesCorrectly()
        {
            //Arrange
            Calculations.AddToMemory(9);
            Calculations.IncrementMemoryIndexByOne();

            //Act
            double Result = Calculations.SquareRootNumber();
            double ExpecteResult = 3;

            //Assert
            Assert.AreEqual(ExpecteResult, Result);
        }

        [TestMethod]
        public void Summarize_OperatorIsPlus_ReturnsAdditionAndEquals20()
        {
            //Arrange
            string Operator = "+";
            Calculations.AddToMemory(10);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(10);

            //Act
            double Result = Calculations.Summarize(Operator);
            double ExpectedResult = 20;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Summarize_OperatorIsMinus_ReturnsSubtractionAndEquals20()
        {
            //Arrange
            string Operator = "-";
            Calculations.AddToMemory(30);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(10);

            //Act
            double Result = Calculations.Summarize(Operator);
            double ExpectedResult = 20;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Summarize_OperatorIsAsterisk_ReturnsMultiplicationAndEquals20()
        {
            //Arrange
            string Operator = "*";
            Calculations.AddToMemory(10);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(2);

            //Act
            double Result = Calculations.Summarize(Operator);
            double ExpectedResult = 20;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Summarize_OperatorIsDivision_ReturnsDivisionAndEquals20()
        {
            //Arrange
            string Operator = "/";
            Calculations.AddToMemory(40);
            Calculations.IncrementMemoryIndexByOne();
            Calculations.AddToMemory(2);

            //Act
            double Result = Calculations.Summarize(Operator);
            double ExpectedResult = 20;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void Summarize_OperatorIsUnknown_ReturnsDivisionAndEquals0()
        {
            //Arrange
            string Operator = "5";
            Calculations.AddToMemory(40);
            Calculations.IncrementMemoryIndexByOne();

            //Act
            double Result = Calculations.Summarize(Operator);
            double ExpectedResult = 0;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void AddtoMemory_MemoryIndexIs99_AddsNewNumberToMemory()
        {
            //Arrange
            Calculations.MemoryIndex = 99;
            double Number = 50;
            bool NumberHasBeenAddedToMemory;

            //Act
            Calculations.AddToMemory(Number);
            if (Calculations.Memory[99] == 50)
            {
                NumberHasBeenAddedToMemory = true;
            }
            else
                NumberHasBeenAddedToMemory = false;

            //Assert
            Assert.IsTrue(NumberHasBeenAddedToMemory);

        }

        [TestMethod]
        public void GiveBackPreviousElementOfMemoryArray_MemoryIndexIs1_ReturnsNumber()
        {
            //Arrange
            Calculations.MemoryIndex = 1;
            Calculations.Memory[0] = 50;

            //Act
            double Result = Calculations.GiveBackPreviousElementOfMemory();
            double ExpectedResult = 50;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void ClearFullMemory_MemoryIsFull_MemoryHasBeenCleared()
        {
            //Arrange
            bool MemoryHasBeenFullyCleared = true;

            for (int i = 0; i < Calculations.Memory.Length; i++)
            {
                Calculations.Memory[i] = 30;
            }

            //Act
            Calculations.ClearFullMemory();

            for (int i = 0; i < Calculations.Memory.Length; i++)
            {
                if (Calculations.Memory[i] != 0)
                {
                    MemoryHasBeenFullyCleared = false;
                }
            }

            //Assert
            Assert.IsTrue(MemoryHasBeenFullyCleared);

        }

        [TestMethod]
        public void GiveBackPreviousElementOfMemoryArray_MemoryIndexIs1_ReturnsPreviousElement()
        {
            //Arrange
            Calculations.MemoryIndex = 1;
            Calculations.Memory[0] = 50;

            //Act
            double Result = Calculations.GiveBackPreviousElementOfMemory();
            double ExpectedResult = 50;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);

        }

        [TestMethod]
        public void GiveBackPreviousElementOfMemoryArray_MemoryIndexIs0_ReturnsExceptionValue()
        {
            //Arrange
            Calculations.MemoryIndex = 0;

            //Act
            double Result = Calculations.GiveBackPreviousElementOfMemory();
            double ExpectedResult = -9999.6677712;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);


        }

        [TestMethod]
        public void IncrementMemoryIndexByOne_MemoryIndexIs0_IncrementsMemoryIndex()
        {
            //Arrange
            Calculations.MemoryIndex = 0;
            bool MemoryIndexHasBeenIncreasedByOne = false;
            double ExpectedResult = Calculations.MemoryIndex + 1;

            //Act
            Calculations.IncrementMemoryIndexByOne();
            if(Calculations.MemoryIndex == ExpectedResult)
            {
                MemoryIndexHasBeenIncreasedByOne = true;
            }


            //Assert
            Assert.IsTrue(MemoryIndexHasBeenIncreasedByOne);
        }

        [TestMethod]
        public void IncrementMemoryIndexByOne_MemoryIndexIs99_DoesNotIncrementMemoryIndex()
        {
            //Arrange
            Calculations.MemoryIndex = 99;
            bool MemoryIndexHasBeenIncreasedByOne = false;
            double ExpectedResult = Calculations.MemoryIndex + 1;

            //Act
            Calculations.IncrementMemoryIndexByOne();
            if (Calculations.MemoryIndex == ExpectedResult)
            {
                MemoryIndexHasBeenIncreasedByOne = true;
            }


            //Assert
            Assert.IsFalse(MemoryIndexHasBeenIncreasedByOne);
        }

        [TestMethod]
        public void AddToResultMemory_ResultMemoryIndexIs0_AddsValueToResultMemory()
        {
            //Arrange
            Calculations.ResultMemoryIndex = 0;
            double Number = 99;
            

            //Act
            Calculations.AddToResultMemory(Number);
            double ExpectedResult = Calculations.ResultMemory[0];

            //Assert
            Assert.AreEqual(ExpectedResult, Number);
        }

        [TestMethod]
        public void IncrementResultMemoryIndexByOne_ResultMemoryIndexIs0_IncrementsResultMemoryIndex()
        {
            //Arrange
            Calculations.ResultMemoryIndex = 0;
            int ExpectedResult = Calculations.ResultMemoryIndex + 1;

            //Act
            Calculations.IncrementResultMemoryIndexByOne();
            
            int Result = Calculations.ResultMemoryIndex;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void IncrementResultMemoryIndexByOne_ResultMemoryIndexIs49_DoesNotIncrementResultMemoryIndex()
        {
            //Arrange
            Calculations.ResultMemoryIndex = 49;
            int ExpectedResult = Calculations.ResultMemoryIndex + 1;

            //Act
            Calculations.IncrementResultMemoryIndexByOne();

            int Result = Calculations.ResultMemoryIndex;

            //Assert
            Assert.AreNotEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GiveBackMostRecentValueOfResultMemory_ResultMemoryIndexIs0_NumbersAreEqual()
        {
            //Arrange
            Calculations.ResultMemoryIndex = 0;
            double RandomNumber = 50;
            Calculations.ResultMemory[0] = RandomNumber;

            //Act
            double Result = Calculations.GiveBackMostRecentValueOfResultMemory();

            //Assert
            Assert.AreEqual(RandomNumber, Result);
        }

        [TestMethod]
        public void RemoveLastNumberUsedByUser_TextIs3990_GivesBackTextWithoutLastNumber()
        {
            //Arrange
            string Text = "3990";
            string ExpectedText = Text.Remove(Text.Length - 1);


            //Act
            string Result = Calculations.RemoveLastNumberUsedByUser(Text);

            //Assert
            Assert.AreEqual(ExpectedText, Result);
        }

        [TestMethod]
        public void GiveBackPreviousElementOfResultMemory_ResultMemoryNavigatorIs1_GivesBackPreviousElement()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 1;
            Calculations.ResultMemory[0] = 50;
            double ExpectedResult = Calculations.ResultMemory[0];
            

            //Act
            double Result = Calculations.GiveBackPreviousElementOfResultMemory();

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GiveBackPreviousElementOfResultMemory_ResultMemoryNavigatorIs0_DoesNotGiveBackPreviousElement()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 0;
            Calculations.ResultMemory[0] = 50;
            double ExpectedResult = Calculations.ResultMemory[0];

            //Act
            double Result = Calculations.GiveBackPreviousElementOfResultMemory();

            //Assert
            Assert.AreNotEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GiveBackNextElementOfResultMemory_ResultMemoryNavigatorIs0_GivesBackNextElement()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 0;
            Calculations.ResultMemory[1] = 50;
            double ExpectedResult = Calculations.ResultMemory[1];

            //Act
            double Result = Calculations.GiveBackNextElementOfResultMemory();

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GiveBackNextElementOfResultMemory_ResultMemoryNavigatorIs50_GivesBackNextElement()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 50;
            Calculations.ResultMemory[1] = 50;
            double ExpectedResult = Calculations.ResultMemory[1];

            //Act
            double Result = Calculations.GiveBackNextElementOfResultMemory();

            //Assert
            Assert.AreNotEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void GiveBackValueOfResultMemoryNavigator_ResultMemoryNavigatorIs1_GivesBack1()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 1;
            int Navigator = Calculations.ResultMemoryNavigator;

            //Act
            int Result = Calculations.GiveBackValueOfResultMemoryNavigator();

            //Assert
            Assert.AreEqual(Result, Navigator);
        }

        [TestMethod]
        public void IncrementResultMemoryNavigatorByOne_ResultMemoryNavigatorIs1_IncrementsByOne()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 1;
            int ExpectedResult = Calculations.ResultMemoryNavigator + 1;
            

            //Act
            Calculations.IncrementResultMemoryNavigatorByOne();
            int Result = Calculations.ResultMemoryNavigator;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

        [TestMethod]
        public void DecrementResultMemoryNavigatorByOne_ResultMemoryNavigatorIs1_DecrementsByOne()
        {
            //Arrange
            Calculations.ResultMemoryNavigator = 1;
            int ExpectedResult = Calculations.ResultMemoryNavigator - 1;

            //Act
            Calculations.DecrementResultMemoryNavigatorByOne();
            int Result = Calculations.ResultMemoryNavigator;

            //Assert
            Assert.AreEqual(ExpectedResult, Result);
        }

    }
}
