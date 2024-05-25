//HintName: G.DomainsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hosted Domains API.
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class DomainsClient : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// Creates a new instance of the DomainsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public DomainsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://ipinfo.io/");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}