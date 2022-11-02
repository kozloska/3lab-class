using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Tests
{
    [TestClass()]
    public class NumberTests
    {

        [TestMethod()]
        public void VerboseTest()
        {
            var number = new Number("10", MeasureType.десятичная);
            Assert.AreEqual("10 десятичная", number.Verbose());

            number = new Number("101", MeasureType.двоичная);
            Assert.AreEqual("101 двоичная", number.Verbose());

            number = new Number("7", MeasureType.восьмеричная);
            Assert.AreEqual("7 восьмеричная", number.Verbose());

            number = new Number("15", MeasureType.шестнадцатеричная);
            Assert.AreEqual("15 шестнадцатеричная", number.Verbose());
        }

        [TestMethod()]
        public void DecToAnyTest()
        {
            Number number;

            number = new Number("12", MeasureType.десятичная);
            Assert.AreEqual("1100 двоичная", number.To(MeasureType.двоичная).Verbose());

            number = new Number("12", MeasureType.десятичная);
            Assert.AreEqual("14 восьмеричная", number.To(MeasureType.восьмеричная).Verbose());

            number = new Number("12", MeasureType.десятичная);
            Assert.AreEqual("c шестнадцатеричная", number.To(MeasureType.шестнадцатеричная).Verbose());
        }

        [TestMethod()]
        public void AnyToDecTest()
        {
            Number number;

            number = new Number("1100", MeasureType.двоичная);
            Assert.AreEqual("12 десятичная", number.To(MeasureType.десятичная).Verbose());

            number = new Number("14", MeasureType.восьмеричная);
            Assert.AreEqual("12 десятичная", number.To(MeasureType.десятичная).Verbose());

            number = new Number("c", MeasureType.шестнадцатеричная);
            Assert.AreEqual("12 десятичная", number.To(MeasureType.десятичная).Verbose());
        }

        [TestMethod()]
        public void AddSubBinDecTest()
        {
            var two = new Number("1100", MeasureType.двоичная);
            var ten = new Number("17", MeasureType.десятичная);

            Assert.AreEqual("29 десятичная", (ten + two).Verbose());
            Assert.AreEqual("11101 двоичная", (two + ten).Verbose());

            Assert.AreEqual("5 десятичная", (ten - two).Verbose());
            Assert.AreEqual("-101 двоичная", (two - ten).Verbose());

            Assert.AreEqual("204 десятичная", (ten * two).Verbose());
            Assert.AreEqual("11001100 двоичная", (two * ten).Verbose());
        }
    }
}