using LittleSpeedyToyRobot.LittleSpeedy.Concrete;
using LittleSpeedyToyRobot.LittleSpeedy.Interface;
using System;
using Xunit;
using static LittleSpeedyToyRobot.Common.Enums;

namespace LittleSpeedyTests
{
    /// <summary>
    /// This is the class that holds the bulk of the tests for LittleSpeedy.
    /// The "Speedy" class is instantiated normally, and there is no reason for it to be mocked
    /// or anything of the sort, as it actually is the SUT (system under test)
    /// </summary>
    /// <remarks>NUnit would do SO MUCH BETTER in these tests, as it offers this amazing and easy-to-use "Random test values generator" attribute</remarks>
    public class SpeedyTests
    {
        /// <summary>
        /// Test method checking that the Place() method actually places Speedy
        /// </summary>
        [Theory]
        [InlineData(0, 0, Direction.East)]
        [InlineData(1, 2, Direction.North)]
        [InlineData(2, 4, Direction.West)]
        [InlineData(4, 0, Direction.East)]
        [InlineData(1, 1, Direction.West)]
        [InlineData(2, 1, Direction.East)]
        public void CheckCorrectlyPlacingLittleSpeedyActuallyPlacesLittleSpeedy(int xPosition, int yPosition, Direction direction) {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(xPosition, yPosition, direction);

            //  Assert
            Assert.Equal(speedy.XPosition, xPosition);
            Assert.Equal(speedy.YPosition, yPosition);
            Assert.Equal(speedy.Direction, direction);
        }

        /// <summary>
        /// Test method checking that the Place() method when invoked with an invalid starting position is properly ignored
        /// </summary>
        [Theory]
        [InlineData(-1, 4,  Direction.East)]
        [InlineData(3,  -4, Direction.North)]
        [InlineData(-6, -3, Direction.West)]
        [InlineData(6,  4,  Direction.East)]
        [InlineData(4,  7,  Direction.West)]
        [InlineData(8,  9,  Direction.East)]
        public void CheckWronglyPlacingLittleSpeedyIsProperlyIgnored(int xPosition, int yPosition, Direction direction) {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(xPosition, yPosition, direction);

            //  Assert
            Assert.Null(speedy.XPosition);
            Assert.Null(speedy.YPosition);
            Assert.Null(speedy.Direction);
        }

        /// <summary>
        /// Test method checking that the Move() method actually moves Speedy.
        /// </summary>
        [Theory]
        [InlineData(0, 0, Direction.North)]
        [InlineData(1, 2, Direction.South)]
        [InlineData(1, 2, Direction.East)]
        [InlineData(1, 2, Direction.West)]
        public void CheckCorrectlyMovingLittleSpeedyActuallyMovesLittleSpeedy(int xPosition, int yPosition, Direction direction) {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(xPosition, yPosition, direction);
            speedy.Move();

            //  Assert
            if (direction == Direction.North || direction == Direction.South) {
                Assert.NotEqual(speedy.YPosition, yPosition);
            } else {
                Assert.NotEqual(speedy.XPosition, xPosition);
            }
        }

        /// <summary>
        /// Test method checking that the Move() method when invoked with an invalid "off the table" argument is properly ignored
        /// </summary>
        [Theory]
        [InlineData(0, 0, Direction.South)]
        [InlineData(4, 4, Direction.North)]
        [InlineData(4, 4, Direction.East)]
        [InlineData(0, 0, Direction.West)]
        public void CheckWronglyMovingLittleSpeedyIsProperlyIgnored(int xPosition, int yPosition, Direction direction) {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(xPosition, yPosition, direction);
            speedy.Move();

            //  Assert
            Assert.Equal(speedy.XPosition, xPosition);
            Assert.Equal(speedy.YPosition, yPosition);
        }

        /// <summary>
        /// (Quite crude) Test method checking that LittleSpeedy actually reports
        /// </summary>
        [Fact]
        public void CheckLittleSpeedyActuallyReports() {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(0, 0, Direction.South);

            //  Assert
            Assert.False(String.IsNullOrEmpty(speedy.Report()));
        }

        /// <summary>
        /// Test method checking that LittleSpeedy actually turns right
        /// </summary>
        [Theory]
        [InlineData(Direction.North,    Direction.East)]
        [InlineData(Direction.East,     Direction.South)]
        [InlineData(Direction.South,    Direction.West)]
        [InlineData(Direction.West,     Direction.North)]
        public void CheckLittleSpeedyActuallyTurnsRight(Direction initialDirection, Direction resultingDirection)
        {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(0, 0, initialDirection);
            speedy.Right();

            //  Assert
            Assert.Equal(speedy.Direction, resultingDirection);
        }

        /// <summary>
        /// Test method checking that LittleSpeedy actually turns left
        /// </summary>
        [Theory]
        [InlineData(Direction.North, Direction.West)]
        [InlineData(Direction.West, Direction.South)]
        [InlineData(Direction.South, Direction.East)]
        [InlineData(Direction.East, Direction.North)]
        public void CheckLittleSpeedyActuallyTurnsLeft(Direction initialDirection, Direction resultingDirection)
        {
            //  Arrange
            ISpeedy speedy = new Speedy();

            //  Act
            speedy.Place(0, 0, initialDirection);
            speedy.Left();

            //  Assert
            Assert.Equal(speedy.Direction, resultingDirection);
        }
    }
}
