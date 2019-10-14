using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises.Classes.Chapter04
{
    public static class Calculator
    {
        private static string Output(double value1, double value2, double result, char @operator)
        {
            return $"{value1} {@operator} {value2} = {result}";
        }

        public static double Add(double value1, double value2)
        {
            var result = value1 + value2;
            return result;
        }
        public static double Add(double value1, double value2, out string output)
        {
            var result = Add(value1, value2);
            output = Output(value1, value2, result, '+');
            return result;
        }

        public static double Substract(double value1, double value2)
        {
            return value1 - value2;
        }
        public static double Substract(double value1, double value2, out string output)
        {
            var result = Substract(value1, value2);
            output = Output(value1, value2, result, '-');
            return result;
        }

        public static double Divide(double value1, double value2)
        {
            return value1 / value2;
        }
        public static double Divide(double value1, double value2, out string output)
        {
            var result = Divide(value1, value2);
            output = Output(value1, value2, result, '/');
            return result;
        }

        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Multiply(double value1, double value2, out string output)
        {
            var result = Multiply(value1, value2);
            output = Output(value1, value2, result, 'x');
            return result;
        }
    }
}
