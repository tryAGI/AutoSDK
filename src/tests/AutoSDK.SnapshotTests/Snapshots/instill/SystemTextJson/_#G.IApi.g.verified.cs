//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Core endpoints to manage user resources<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// User endpoints
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// Organization endpoints
        /// </summary>
        public OrganizationClient Organization { get; }

        /// <summary>
        /// Membership endpoints
        /// </summary>
        public MembershipClient Membership { get; }

        /// <summary>
        /// Token endpoints
        /// </summary>
        public TokenClient Token { get; }

        /// <summary>
        /// Subscription endpoints
        /// </summary>
        public SubscriptionClient Subscription { get; }

        /// <summary>
        /// Credit endpoints
        /// </summary>
        public CreditClient Credit { get; }

        /// <summary>
        /// Metric endpoints
        /// </summary>
        public MetricClient Metric { get; }

        /// <summary>
        /// Util endpoints
        /// </summary>
        public UtilsClient Utils { get; }

        /// <summary>
        /// 
        /// </summary>
        public CatalogClient Catalog { get; }

    }
}