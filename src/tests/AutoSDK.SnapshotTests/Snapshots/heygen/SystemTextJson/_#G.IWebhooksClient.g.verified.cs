//HintName: G.IWebhooksClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook events are how the **HeyGen** notifies your _endpoints_ when a variety of interactions or events happen, including when avatar video processing _succeeds_ or _fails_. Webhook events are sent by HeyGen as POST requests to your webhook endpoint.<br/>
    /// **Guide**: [https://docs.heygen.com/docs/using-heygens-webhook-events](https://docs.heygen.com/docs/using-heygens-webhook-events)**Reference**: [https://docs.heygen.com/reference/add-a-webhook-endpoint](https://docs.heygen.com/reference/add-a-webhook-endpoint)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IWebhooksClient : global::System.IDisposable
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
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}