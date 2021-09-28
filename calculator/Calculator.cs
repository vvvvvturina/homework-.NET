using System;
using System.Diagnostics.CodeAnalysis;

namespace calculator
{
    public class Calculator
    {
        
        public enum operation
        {
            Addition,
            Substraction,
            Multiplication,
            Division,
            NotOperator
        }
        
        public static Exception NotAnOperatorException = new Exception("The operator doesn't exist.");
        public static Exception CanNotDivideByZero = new Exception("Can not divide by zero.");

        public static operation GetOperator(string argument)
        {
            operation operationType = operation.NotOperator;
            switch (argument)
            {
                case "+":
                    operationType = operation.Addition;
                    break;
                case "-":
                    operationType = operation.Substraction;
                    break;
                case "*":
                    operationType = operation.Multiplication;
                    break;
                case "/":
                    operationType = operation.Division;
                    break;
            }
            return operationType;
        }
        
        public static double Calculate(int a, int b, operation operation)
        {
            double result = 0;
            switch (operation)
            {
                case operation.Addition:
                    result = a + b;
                    break;
                case operation.Division:
                    if (b==0)
                    {
                        throw CanNotDivideByZero;
                    }
                    else
                    {
                        result = a / b;
                    }
                    break;
                case operation.Multiplication:
                    result = a * b;
                    break;
                case operation.Substraction:
                    result = a - b;
                    break;
                case operation.NotOperator:
                    throw NotAnOperatorException;
            }
            return result;
        }
    }
}