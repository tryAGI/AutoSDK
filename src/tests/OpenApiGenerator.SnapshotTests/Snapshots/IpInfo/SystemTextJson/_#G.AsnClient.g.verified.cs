//HintName: G.AsnClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ASN API.
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class AsnClient : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Creates a new instance of the AsnClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public AsnClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://ipinfo.io/");
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions();
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}