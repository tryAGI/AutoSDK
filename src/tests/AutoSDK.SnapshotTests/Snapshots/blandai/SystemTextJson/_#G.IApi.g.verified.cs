//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bland AI is an enterprise-grade platform for AI-powered phone calls. It enables sending outbound calls, receiving inbound calls, managing conversational pathways, batch calling, voice selection, and post-call analysis.<br/>
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
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Account information and billing.
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// Create and manage batch call campaigns.
        /// </summary>
        public BatchesClient Batches { get; }

        /// <summary>
        /// Send, manage, and analyze AI phone calls.
        /// </summary>
        public CallsClient Calls { get; }

        /// <summary>
        /// Phone number management (inbound/outbound).
        /// </summary>
        public NumbersClient Numbers { get; }

        /// <summary>
        /// Conversational pathway CRUD operations.
        /// </summary>
        public PathwaysClient Pathways { get; }

        /// <summary>
        /// Voice listing and management.
        /// </summary>
        public VoicesClient Voices { get; }

    }
}