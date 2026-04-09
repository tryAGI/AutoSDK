//HintName: G.ExportFromDescriptClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Users of Descript currently have three options to export their edited content. They can export files in various<br/>
    /// formats, share a Descript link, or use our [one-click cloud export](https://help.descript.com/hc/en-us/articles/360043869551-Becoming-a-Supported-Content-Hosting-Partner)<br/>
    /// to publish directly to a partner.<br/>
    /// ### Roundtrip Metadata<br/>
    /// If Project data previously came from a partner via an Edit in Descript schema then any Descript Export pages<br/>
    /// will include `&lt;meta/&gt;` tags which contains the `partner_drive_id` and `source_id` provided when originally<br/>
    /// importing into Descript. This allows partners to deduplicate data returning back to partner systems after<br/>
    /// editing in Descript. Both partner and source properties are included on all public Descript Export pages.<br/>
    /// ```<br/>
    /// &lt;meta property="descript:partner" content="9121bf3a-60fe-4a31-ad59-ed32df610cc3" /&gt;<br/>
    /// &lt;meta property="descript:source" content="409148bd-81aa-4af6-a9c3-29b761506f3a" /&gt;<br/>
    /// ```.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ExportFromDescriptClient : global::G.IExportFromDescriptClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://descriptapi.com/v1";

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
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions();


        /// <summary>
        /// Creates a new instance of the ExportFromDescriptClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ExportFromDescriptClient(
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