using Xunit;
using StringManipulation;

namespace StringManipulationTests
{
    public class StringOperationsTest{

        [Fact]
        public void ConcatenateStrings(){
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.ConcatenateStrings("Hey there", "universe");

            // Assert
            Assert.Equal(result, "Hey there universe");
        }

        [Fact]
        public void IsPalindrome_True(){
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.IsPalindrome("reconocer");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False(){
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.IsPalindrome("isla");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace(){
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.RemoveWhitespace("Comenzar es la mitad del camino");

            // Assert
            Assert.Equal(result, "Comenzareslamitaddelcamino");
        }

        [Fact]
        public void QuantintyInWords(){
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.QuantintyInWords("ave", 8);

            // Assert
            Assert.StartsWith("ocho", result);
            Assert.Contains("ave", result);
        }

        [Fact]
        public void GetStringLength_Exception(){

            var strOperations = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
        }

        [Theory]
        [InlineData("X", 10)]
        [InlineData("IV", 4)]
        [InlineData("II", 2)]
        [InlineData("L", 50)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            var strOperations = new StringOperations();

            var result = strOperations.FromRomanToNumber(romanNumber);

            Assert.Equal(result, expected);
        }
    }
}