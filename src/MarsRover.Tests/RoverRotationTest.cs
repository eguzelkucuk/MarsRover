using MarsRover.Case.Core;
using System;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverRotationTest
    {
        [Fact]
        public void InitialRoverPosition()
        {
            Plateau plateauOne = new(new Position(5, 5));
            Rover firstRover = new(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");
            Assert.Equal("1 3 N", firstRover.ToString());
        }


        [Fact]
        public void Rover_Should_Change_Position_When_CorrectInput()
        {
            Plateau plateauTwo = new(new Position(5, 5));
            Rover secondRover = new(plateauTwo, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");
            Assert.Equal("5 1 E", secondRover.ToString());
        }

        [Theory]
        [InlineData("BCR")]
        [InlineData("MRMSCR")]
        [InlineData("ASDEWR")]
        public void Process_Should_Throw_ArgumentException_When_IncorrectInput(string routes)
        {
            Plateau plateauOne = new(new Position(5, 5));
            Rover firstRover = new(plateauOne, new Position(1, 2), Directions.N);
            Assert.Throws<ArgumentException>(()=> firstRover.Process(routes));
        }
    }
}