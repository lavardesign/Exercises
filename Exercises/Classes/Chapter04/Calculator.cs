using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises.Classes.Chapter04
{
    public class Calculator
    {
        public double Add(double value1, double value2)
        {
            var result = value1 + value2;
            return result;
        }

        public double Substract(double value1, double value2)
        {
            return value1 - value2;
        }

        public double Divide(double value1, double value2)
        {
            return value1 / value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
    }
}
