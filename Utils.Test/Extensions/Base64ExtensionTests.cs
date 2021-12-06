using Jitesoft.Utils.Extensions;
using Xunit;

namespace Jitesoft.Utils.Test.Extensions
{
    public class Base64ExtensionTests
    {
        [Theory]
        [InlineData("dGVzdA", "dGVzdA==")]
        [InlineData("dGVz", "dGVz")]
        [InlineData("dGVzdGluZw", "dGVzdGluZw==")]
        public void TestAddPadding(string input, string expected)
        {
            Assert.Equal(expected, input.AddBase64Padding());
        }

        [Theory]
        [InlineData("dGVzdA==", "dGVzdA")]
        [InlineData("dGVz", "dGVz")]
        [InlineData("dGVzdGluZw==", "dGVzdGluZw")]
        public void TestRemovePadding(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveBase64Padding());
        }
    }
}
