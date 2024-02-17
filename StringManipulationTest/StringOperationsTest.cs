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
    }
}