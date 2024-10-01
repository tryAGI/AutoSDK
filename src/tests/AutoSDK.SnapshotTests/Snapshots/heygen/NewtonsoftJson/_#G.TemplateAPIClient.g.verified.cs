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
        public const string BaseUrl = "https://api.heygen.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::G.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Creates a new instance of the TemplateAPIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public TemplateAPIClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();

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