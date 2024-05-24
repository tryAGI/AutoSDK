//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        public GeneralClient General => new GeneralClient(_httpClient);
        public SingleClient Single => new SingleClient(_httpClient);
        public PrivacyDetectionClient PrivacyDetection => new PrivacyDetectionClient(_httpClient);
        public AsnClient Asn => new AsnClient(_httpClient);
        public RangesClient Ranges => new RangesClient(_httpClient);
        public DomainsClient Domains => new DomainsClient(_httpClient);
        public AbuseClient Abuse => new AbuseClient(_httpClient);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public Api(
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