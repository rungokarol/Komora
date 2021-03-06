﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace Komora.Test.Utilities
{
    [TestFixture]
    public class Pt100converterTests
    {
        Komora.Classes.DataBase.Pt100_Poly pt100Poly;
        Komora.Utilities.Pt100converter pt100Converter;
        const int scaler = 100;

        [SetUp]
        public void Init()
        {      
            pt100Poly = new Classes.DataBase.Pt100_Poly();          
        }

        [Test]
        public void getCoefficientsReturnsGoodList()
        {         
            pt100Poly.Coefficients = "3.33:2.22:1.11";
            pt100Converter = new Komora.Utilities.Pt100converter(pt100Poly.Coefficients, scaler);
                      
            pt100Converter.getCoefficients();

            List<double> expectedCoefficients = new List<double>(){3.33, 2.22, 1.11};

            for (int i = 0; i < expectedCoefficients.Count; i++)
            {
                Assert.That (expectedCoefficients[i], Is.EqualTo(pt100Converter.Coefficients[i]).Within(0.01));
            }
        }

        [Test]
        public void temperatureToResistanceRerurnsProperValue()
        {
            pt100Poly.Coefficients = "100:0.38";
            pt100Converter = new Komora.Utilities.Pt100converter(pt100Poly.Coefficients, scaler);

            double temperature = 0;
            long expectedResult = 10000;
            Assert.AreEqual(expectedResult, pt100Converter.temperatureToResistance(temperature));

            temperature = 1;
            expectedResult = 10038;
            Assert.AreEqual(expectedResult, pt100Converter.temperatureToResistance(temperature));

            temperature = 40;
            expectedResult = 11520;
            Assert.AreEqual(expectedResult, pt100Converter.temperatureToResistance(temperature));
        }

        [TestCase(11330, 35, 0.8)]
        [TestCase(11520, 40, 0.6)]
        [TestCase(11710, 45, 0.3)]
        [TestCase(11900, 50, 0.01)]
        [TestCase(12850, 75, 1.4)]
        [TestCase(13800, 100, 0.01)]
        public void resistanceToTemperatureReturnsProperValue(long resistance, double expectedResult, double accuracy)
        {
            pt100Poly.Coefficients = "100:0.38";
            pt100Converter = new Komora.Utilities.Pt100converter(pt100Poly.Coefficients, scaler);

            Assert.That(pt100Converter.resistanceToTemperature(resistance), Is.EqualTo(expectedResult).Within(accuracy));
        }
    }
}
