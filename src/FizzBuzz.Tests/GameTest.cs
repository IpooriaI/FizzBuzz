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
        public void Number_is_devidable_to_3()
        {
            var number = 50;

            var expectation = _sut.CheckDividableby3();

            expectation.Should().Be(0);
        }

    }
}
