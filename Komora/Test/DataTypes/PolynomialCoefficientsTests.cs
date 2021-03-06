﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace Komora.Test.DataTypes
{
    [TestFixture]
    public class PolynomialCoefficientsTests
    {
        Komora.DataTypes.PolynomialCoefficients<double> polynomial;

        [Test]
        public void canCreatePolynomialCoefficients()
        {
            polynomial = new Komora.DataTypes.PolynomialCoefficients<double>(
                                               new List<double>() { 1, 2, 3, 4, 5 }
                                               );

            Assert.AreEqual(new List<double>() { 1, 2, 3, 4, 5 }, polynomial.getCoefficients());
            Assert.AreEqual(4, polynomial.Degree);
        }

        [Test]
        public void setCoefficientsSetsProperValueToList()
        {
            polynomial.setCoefficients(new List<double>() { 10, 20, 30, 40, 50 });

            Assert.AreEqual(new List<double>() { 10, 20, 30, 40, 50 }, polynomial.getCoefficients());
            Assert.AreEqual(4, polynomial.Degree);
        }

        [Test]
        public void toStringReturnsPorperString()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            polynomial = new Komora.DataTypes.PolynomialCoefficients<double>(new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 });

            Assert.That("1.0000:2.0000:3.0000:4.0000:5.0000", Is.EqualTo(polynomial.ToString()));
        }
    }
}
