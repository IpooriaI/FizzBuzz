using FizzBuzz.Logic;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.Tests
{
    public class GameTest
    {
        private readonly Game _sut;

        public GameTest()
        {
            _sut = new Game();
        }

        [Fact]
        public void Checker_should_say_FizzBuzz_if_the_number_divided_by_3_and_5_is_0()
        {
            var number = 9;

            var expectation = _sut.DivideBy3And5(number);

            expectation.Should().Be("FizzBuzz");
        }

        [Fact]
        public void Checker_should_say_Fizz_if_the_number_divided_by_3_is_0()
        {
            var number = 9;

            var expectation = _sut.DivideBy3(number);

            expectation.Should().Be("Fizz");
        }    
        
        [Fact]
        public void Checker_should_say_Buzz_if_the_number_divided_by_5_is_0()
        {
            var number = 25;

            var expectation = _sut.DivideBy5(number);

            expectation.Should().Be("Buzz");
        }

    }
}
