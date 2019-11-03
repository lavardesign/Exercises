﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter07;

namespace Exercises.Tests.Chapter07
{
    public class CalculatorTests
    {
        [Fact]
        public void CanCreateOperationInstance()
        {
            var operation = new Operation(10, Operators.Multiply);

            Assert.NotNull(operation);
            Assert.Equal(10, operation.Value);
            Assert.Equal(Operators.Multiply, operation.Operator);
        }
        [Fact]
        public void CanChangeValuesInOperationInstance()
        {
            var operation = new Operation(10, Operators.Multiply);
            operation.SetValue(20);
            operation.SetOperator(Operators.Divide);

            Assert.Equal(20, operation.Value);
            Assert.Equal(Operators.Divide, operation.Operator);
        }
        [Fact]
        public void CanChangeValuesWithExtensionMethodsInAnOperationInstance()
        {
            var operation = new Operation(10, Operators.Multiply);
            operation.ChangeValue(20);
            operation.ChangeOperator(Operators.Divide);

            Assert.Equal(20, operation.Value);
            Assert.Equal(Operators.Divide, operation.Operator);
        }
        [Fact]
        public void CanCalculateWithTheCalculateExtensionMethodInAnOperationInstance()
        {
            var operation1 = new Operation(10, Operators.Multiply);
            var operation2 = new Operation(20, Operators.Equals);
            var result = operation1.Calculate(operation2);

            Assert.Equal(200, result.Value);
            Assert.Equal(Operators.Equals, result.Operator);
        }
        [Fact]
        public void CanCreaateCalculatorInstance()
        {
            var calculator = new Calculator();

            Assert.NotNull(calculator);
        }
        [Fact]
        public void CanAddOperationToCalculatorInstance()
        {
            var calculator = new Calculator();
            var operation = new Operation(10, Operators.Multiply);
            calculator.AddOperation(operation);

            Assert.Contains(operation, calculator.Operations);
        }
        [Fact]
        public void CanCalculateWithEmptyListCalculatorInstance()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate();

            Assert.Equal(default, result);
        }
        [Fact]
        public void CanCalculateWithOneOperationCalculatorInstance()
        {
            var calculator = new Calculator();
            var operation = new Operation(10, Operators.Multiply);
            calculator.AddOperation(operation);
            var result = calculator.Calculate();

            Assert.Equal(10, result);
        }
        [Fact]
        public void CanCalculateWithManyOperationsCalculatorInstance()
        {
            var calculator = new Calculator();
            var operation1 = new Operation(10, Operators.Multiply);
            var operation2 = new Operation(20, Operators.Divide);
            var operation3 = new Operation(2, Operators.Add);
            var operation4 = new Operation(30, Operators.Subtract);
            var operation5 = new Operation(50, Operators.Equals);
            calculator.AddOperation(operation1);
            calculator.AddOperation(operation2);
            calculator.AddOperation(operation3);
            calculator.AddOperation(operation4);
            calculator.AddOperation(operation5);
            var result = calculator.Calculate();

            Assert.Equal(80, result);
        }
    }
}
