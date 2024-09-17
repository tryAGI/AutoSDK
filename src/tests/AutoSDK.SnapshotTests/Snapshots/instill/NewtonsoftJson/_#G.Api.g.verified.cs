//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Core endpoints to manage user resources<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.instill.tech";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// User endpoints
        /// </summary>
        public UserClient User => new UserClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Organization endpoints
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Membership endpoints
        /// </summary>
        public MembershipClient Membership => new MembershipClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Token endpoints
        /// </summary>
        public TokenClient Token => new TokenClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Subscription endpoints
        /// </summary>
        public SubscriptionClient Subscription => new SubscriptionClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Credit endpoints
        /// </summary>
        public CreditClient Credit => new CreditClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Metric endpoints
        /// </summary>
        public MetricClient Metric => new MetricClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Util endpoints
        /// </summary>
        public UtilsClient Utils => new UtilsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CatalogClient Catalog => new CatalogClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

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
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}