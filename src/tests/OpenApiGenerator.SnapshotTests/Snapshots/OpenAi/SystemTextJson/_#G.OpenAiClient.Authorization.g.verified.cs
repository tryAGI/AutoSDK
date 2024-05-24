//HintName: G.OpenAiClient.Authorization.g.cs

#nullable enable

namespace G
{
    public sealed partial class OpenAiClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                scheme: "Bearer",
                parameter: apiKey);
        }
    }
}