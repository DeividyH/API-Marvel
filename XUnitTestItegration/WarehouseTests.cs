using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestItegration
{
    public class WarehouseTests : IClassFixture<TestFixture<APIMarvel.Startup>>
    {
        private HttpClient Client;

        public WarehouseTests(TestFixture<APIMarvel.Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task TestGetCharacter()
        {
            // Arrange
            var request = "/v1/public/character";

            // Act
            var response = await Client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
