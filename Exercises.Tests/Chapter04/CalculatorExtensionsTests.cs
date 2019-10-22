﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter04;

namespace Exercises.Tests.Chapter04
{
    public class CalculatorExtensionsTests
    {
        [Fact]
        public void CanCreateValuesDefaultInstance()
        {
            var values = new Values(10, 20);

            Assert.NotNull(values);
            Assert.Equal(10, values.Value1);
            Assert.Equal(20, values.Value2);
            Assert.Equal(default, values.Result);
            Assert.Equal(default, values.Operator);
        }

        [Fact]
        public void CanCallAddExtensionMethod()
        {
            var values = new Values(10, 20);
            values.Add();
            var output = values.Output();

            Assert.NotNull(values);
            Assert.Equal(30, values.Result);
            Assert.Equal("10 + 20 = 30", output);
        }

        [Fact]
        public void CanCallAddAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Add().Output();
            
            Assert.NotNull(values);
            Assert.Equal(30, values.Result);
            Assert.Equal("10 + 20 = 30", output);
        }

        [Fact]
        public void CanCallSubstractAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Substract().Output();

            Assert.NotNull(values);
            Assert.Equal(-10, values.Result);
            Assert.Equal("10 - 20 = -10", output);
        }

        [Fact]
        public void CanCallDivideAddAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Divide().Output();

            Assert.NotNull(values);
            Assert.Equal(0.5, values.Result);
            Assert.Equal("10 / 20 = 0,5", output);
        }

        [Fact]
        public void CanCallMultiplyAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Multiply().Output();

            Assert.NotNull(values);
            Assert.Equal(200, values.Result);
            Assert.Equal("10 x 20 = 200", output);
        }
    }
}
