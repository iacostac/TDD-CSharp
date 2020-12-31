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
        public void Buzzer_WhenDefault_ReturnsInput( [Values(1,2,4,7,8)] int input)
        {


            string output = FizzBuzzer.GetValue(input);


            Assert.AreEqual(input.ToString(), output);


        }



        [Test]
        public void Buzzer_WhenDiv3_ReturnFizz([Values(3,6,9)] int input)
        {
        

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);



        }


        [Test]
        public void Buzzer_WhenDiv5_returnsBuzz([Values(5, 10, 20)] int input)
        {
           

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);

        }


        [Test]

        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz([Values(15,30)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);

        }


    }
}
