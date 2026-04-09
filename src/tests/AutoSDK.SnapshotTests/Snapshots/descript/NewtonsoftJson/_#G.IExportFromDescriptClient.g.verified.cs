//HintName: G.IExportFromDescriptClient.g.cs

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
    public partial interface IExportFromDescriptClient : global::System.IDisposable
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
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}