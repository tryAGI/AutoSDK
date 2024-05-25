//HintName: G.AudioClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn how to turn audio into text or text into audio.
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class AudioClient : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// Creates a new instance of the AudioClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public AudioClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.openai.com/v1");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}