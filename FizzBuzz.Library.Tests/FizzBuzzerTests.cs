using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Library;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {

        [Test]
        public void Buzzer_When1_Returns1()
        {
            int input = 1;


            string output = FizzBuzzer.GetValue(input);


            Assert.AreEqual("1", output);


        }



        [Test]
        public void Buzzer_When2_Return2()
        {
            int input = 2;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("2", output);

        }

    }
}
