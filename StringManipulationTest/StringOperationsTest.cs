using Xunit;
using StringManipulation;
using Moq;
using Microsoft.Extensions.Logging;


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

        [Fact(Skip = "Esta prueba no es válida en este momento, TICKET-001")]
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

        [Fact]
        public void CountOccurrences(){

            var mockLogger = new Mock<ILogger<StringOperations>>();
            var strOperations = new StringOperations(mockLogger.Object);

            var result = strOperations.CountOccurrences("Hello dear friends", 'e');

            Assert.Equal(3, result);
        }

        [Fact]
        public void ReadFile(){

            // Arrange
            var strOperations = new StringOperations();
            var mockFileReader = new Mock<IFileReaderConector>();

            // Act
            //mockFileReader.Setup(p => p.ReadString("information.txt")).Returns("Reading file...");
            mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading file...");

            var result = strOperations.ReadFile(mockFileReader.Object, "information.txt");

            // Assert
            Assert.Equal(result, "Reading file...");
        }
    
        [Fact]
        public void ReverseString(){
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.ReverseString("welcome");

            // Assert
            Assert.Equal(result, "emoclew");
        }
    
        [Fact]
        public void GetStringLength(){
            var strOperations = new StringOperations();

            var result = strOperations.GetStringLength("Ambivalencia");

            Assert.Equal(result, 12);
        }

        [Fact]
        public void TruncateString(){
            var strOperations = new StringOperations();

            var result = strOperations.TruncateString("Ambiguedad", 4);

            Assert.Equal(result, "Ambi");
        }

        [Fact]
        public void Pluralize(){
            var strOperations = new StringOperations();

            var result = strOperations.Pluralize("Body");

            Assert.Equal(result, "Bodies");
        }
    }
}