using BlazorApp_Study.Shared;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly IHttpClientFactory _httpClientFactory =
            new ServiceCollection()
                .AddHttpClient()
                .BuildServiceProvider()
                .GetRequiredService<IHttpClientFactory>();


        [Fact]
        public async Task Test1Async()
        {
            var httpClient = _httpClientFactory.CreateClient();
            //テスト用サイトにHTTPリクエストを送る
            var result = await httpClient.GetAsync("https://0807cicd.azurewebsites.net/");

            Assert.NotNull(result);
            Assert.True(result.IsSuccessStatusCode);
        }
    }
}