// ********RoostGPT********
// Test generated by RoostGPT for test Csharp-beginner using AI Type Open AI and AI Model gpt-4-1106-preview



// ********RoostGPT********
using NUnit.Framework;

namespace TicTacToe.Test
{
    [TestFixture]
    public class Player_dc090f1b73
    {
        [Test]
        public void Constructor_ValidParameters_ShouldCreatePlayer()
        {
            // Arrange
            byte expectedId = 1; // TODO: Change the value if necessary
            string expectedDisplay = "X"; // TODO: Change the value if necessary

            // Act
            var player = new TicTacToe.Player(expectedId, expectedDisplay);

            // Assert
            Assert.That(player.Id, Is.EqualTo(expectedId), "Constructor did not set the Id correctly.");
            Assert.That(player.Display, Is.EqualTo(expectedDisplay), "Constructor did not set the Display correctly.");
        }

        [Test]
        public void Constructor_EmptyDisplay_ShouldCreatePlayerWithEmptyDisplay()
        {
            // Arrange
            byte expectedId = 1; // TODO: Change the value if necessary
            string expectedDisplay = string.Empty;

            // Act
            var player = new TicTacToe.Player(expectedId, expectedDisplay);

            // Assert
            Assert.That(player.Id, Is.EqualTo(expectedId), "Constructor did not set the Id correctly.");
            Assert.That(player.Display, Is.EqualTo(expectedDisplay), "Constructor did not set the Display correctly.");
        }

        [Test]
        public void Constructor_IdAtUpperBound_ShouldCreatePlayerWithMaxId()
        {
            // Arrange
            byte expectedId = 255; // TODO: Change the value if necessary
            string expectedDisplay = "O"; // TODO: Change the value if necessary

            // Act
            var player = new TicTacToe.Player(expectedId, expectedDisplay);

            // Assert
            Assert.That(player.Id, Is.EqualTo(expectedId), "Constructor did not set the Id at the upper bound correctly.");
            Assert.That(player.Display, Is.EqualTo(expectedDisplay), "Constructor did not set the Display correctly.");
        }

        [Test]
        public void Constructor_IdAtLowerBound_ShouldCreatePlayerWithMinId()
        {
            // Arrange
            byte expectedId = 0; // TODO: Change the value if necessary
            string expectedDisplay = "O"; // TODO: Change the value if necessary

            // Act
            var player = new TicTacToe.Player(expectedId, expectedDisplay);

            // Assert
            Assert.That(player.Id, Is.EqualTo(expectedId), "Constructor did not set the Id at the lower bound correctly.");
            Assert.That(player.Display, Is.EqualTo(expectedDisplay), "Constructor did not set the Display correctly.");
        }
    }
}

