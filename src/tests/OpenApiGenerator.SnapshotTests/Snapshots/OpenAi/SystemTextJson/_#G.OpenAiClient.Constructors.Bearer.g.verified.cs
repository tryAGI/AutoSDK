//HintName: G.OpenAiClient.Constructors.Bearer.g.cs

#nullable enable

namespace G
{
    public sealed partial class OpenAiClient
    {
        /// <inheritdoc cref="OpenAiClient(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public OpenAiClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}