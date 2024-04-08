using Xunit;
using HelloWorld;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void GetHelloWorldMessage_ReturnsCorrectMessage()
        {
            // Act
            var result = Program.GetHelloWorldMessage();

            // Assert
            Assert.Equal("Hello World!", result);
        }
    }
}
