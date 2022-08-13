namespace BlazorApp_Study.Shared
{
    public class TestClass
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestClass(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> TestHttpMethod()
        {
            var httpClient = _httpClientFactory.CreateClient();

            //テスト用サイトにHTTPリクエストを送る
            var result = await httpClient.GetAsync("https://0807cicd.azurewebsites.net/");

            return result.IsSuccessStatusCode;
        }
    }
}