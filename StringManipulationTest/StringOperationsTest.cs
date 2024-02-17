using Xunit;
using StringManipulation;

namespace StringManipulationTests
{
    public class StringOperationsTest{

        [Fact]
        public void ConcatenateStrings(){
            var strOperations = new StringOperations();

            var result = strOperations.ConcatenateStrings("Hey there", "universe");

            Assert.Equal(result, "Hey there universe");
        }
    }
}