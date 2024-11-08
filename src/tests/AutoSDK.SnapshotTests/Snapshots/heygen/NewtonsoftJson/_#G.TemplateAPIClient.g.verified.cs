//HintName: G.TemplateAPIClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Templates enable you to add and customize existing text, images, videos, audios (coming soon), voices and avatars, while avatar videos consist only of avatars without these elements. If you plan to use it within a workflow and need richer content, templates are likely a better fit for your use case compared to simple talking avatar videos. 🌟<br/>
    /// **Quick Comparison:**<br/>
    /// - **Avatar Videos:** Avatar videos are centered around avatars delivering content without any additional elements. They are ideal for straightforward, avatar-focused communication.<br/>
    ///     <br/>
    /// - **Template Videos:** In contrast, template videos offer a wide canvas for creativity. They enable you to customize existing text, images, videos, audios, voices and avatars seamlessly. If you need a richer, more versatile content format for your workflow, templates are the perfect choice.<br/>
    ///     <br/>
    /// **Guide**: [https://docs.heygen.com/docs/generate-video-from-template-v2](https://docs.heygen.com/docs/generate-video-from-template-v2)  <br/>
    /// **Reference**: [https://docs.heygen.com/reference/generate-from-template-v2](https://docs.heygen.com/reference/generate-from-template-v2)[](https://docs.heygen.com/reference/create-an-avatar-video-v2)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TemplateAPIClient : global::G.ITemplateAPIClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.heygen.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Creates a new instance of the TemplateAPIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TemplateAPIClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
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