//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [https://ipinfo.io](https://ipinfo.io).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://ipinfo.io/";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// General API.
        /// </summary>
        public GeneralClient General => new GeneralClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Single info API.
        /// </summary>
        public SingleClient Single => new SingleClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Privacy Detection API.
        /// </summary>
        public PrivacyDetectionClient PrivacyDetection => new PrivacyDetectionClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// ASN API.
        /// </summary>
        public AsnClient Asn => new AsnClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// IP Ranges API.
        /// </summary>
        public RangesClient Ranges => new RangesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Hosted Domains API.
        /// </summary>
        public DomainsClient Domains => new DomainsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Abuse Contact API.
        /// </summary>
        public AbuseClient Abuse => new AbuseClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.AsnResponseTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AsnResponseTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CompanyTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CompanyTypeNullableJsonConverter(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}