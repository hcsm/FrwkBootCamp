using System.Net;
using FluentAssertions;
using System.Threading.Tasks;
using FrameBook.StackAPITest.Fixtures;
using Xunit;

namespace FrameBook.StackAPITest.Scenarios
{
    public class ValuesTest
    {
        private readonly TestContext _testContext;

        public ValuesTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Values_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("api/v1/values");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
