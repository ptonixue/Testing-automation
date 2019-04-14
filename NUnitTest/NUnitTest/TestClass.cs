// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class TestClass
    {
        [Test, TestCaseSource("TestCases")]
        public void multiplication(double x, double y)
        {
            Calculator.Methods operation = new Calculator.Methods();
            var result = operation.multiplication(x, y);
            Assert.AreEqual(x * y, result, "wrong test {0} * {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void addition(double x, double y)
        {
            Calculator.Methods operation = new Calculator.Methods();
            var result = operation.addition(x, y);
            Assert.AreEqual(x + y, result, "wrong test {0} + {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void difference(double x, double y)
        {
            Calculator.Methods operation = new Calculator.Methods();
            var result = operation.difference(x, y);
            Assert.AreEqual(x - y, result, "wrong test {0} - {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void division(double x, double y)
        {
            Calculator.Methods operation = new Calculator.Methods();
            var result = operation.division(x, y);
            Assert.AreEqual(x / y, result, "wrong test {0} / {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void multiplicationOperation(double x, double y)
        {
            var result = Calculator.Calculator.calculator(x, y, "*");
            Assert.AreEqual(x * y, result, "wrong test {0} * {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void additionOperation(double x, double y)
        {
            var result = Calculator.Calculator.calculator(x, y, "+");
            Assert.AreEqual(x + y, result, "wrong test {0} + {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void differenceOperation(double x, double y)
        {
            var result = Calculator.Calculator.calculator(x, y, "-");
            Assert.AreEqual(x - y, result, "wrong test {0} - {1} = {2}", x, y, result);
        }

        [Test, TestCaseSource("TestCases")]
        public void divisionOperation(double x, double y)
        {
            var result = Calculator.Calculator.calculator(x, y, "/");
            Assert.AreEqual(x / y, result, "wrong test {0} / {1} = {2}", x, y, result);
        }

        static IEnumerable<int[]> TestCases()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    yield return new int[] { i, j };
                }
            }
        }
    }
}
