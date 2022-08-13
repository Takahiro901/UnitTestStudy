using BlazorApp_Study.Shared;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1Async()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient();
            var services = serviceCollection.BuildServiceProvider();
            var httpClientFactory = services.GetRequiredService<IHttpClientFactory>();

            var testClass = new TestClass(httpClientFactory);

            var result = await testClass.TestHttpMethod();
            Assert.True(result);
        }

        [Fact]
        public async Task Test2Async()
        {
            var httpClientFactoryMock = new Mock<IHttpClientFactory>();

            var testClass = new TestClass(httpClientFactoryMock.Object);

            var result = await testClass.TestHttpMethod();
            Assert.True(result);
        }
    }
}