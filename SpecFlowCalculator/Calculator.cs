using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Substract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Divide()
        {
            try
            {
                int result = FirstNumber / SecondNumber;
            }
            catch (DivideByZeroException)
            {
                 throw new Exception("Error");
            }
            return FirstNumber / SecondNumber;
        }

        public int SuperCalculator()
        {
              
            List<int> queueNumbers = Operation.Split('+','-','*','/').Select(n => int.Parse(n)).ToList();
            List<char> allPossibleOperators = new List<char> { '+', '-', '*', '/' };
            List<char> operators = Operation.Where(Op => allPossibleOperators.Contains(Op)).ToList(); 

            int result = 0;
            FirstNumber = queueNumbers[0];

            for (int i = 1; i < queueNumbers.Count; i++) {
                SecondNumber = queueNumbers[i];
                
                    if (operators[i - 1].Equals('+'))
                    {
                        result = Add();
                    }
                    else if (operators[i-1].Equals('-'))
                    {
                        result = Substract();
                    }
                    else if (operators[i - 1].Equals('*'))
                    {
                        result = Multiply();
                    }
                    else if (operators[i - 1].Equals('/'))
                    {
                        result = Divide();
                    }
                    FirstNumber = result;
                }
            
            return result;
        }
            
        



    }
}