//HintName: G.Models.FetchCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchCreateRequest
    {
        /// <summary>
        /// The URL to fetch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Whether to follow HTTP redirects<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowRedirects")]
        public bool? AllowRedirects { get; set; }

        /// <summary>
        /// Whether to bypass TLS certificate verification<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowInsecureSsl")]
        public bool? AllowInsecureSsl { get; set; }

        /// <summary>
        /// Whether to enable proxy support for the request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxies")]
        public bool? Proxies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to fetch
        /// </param>
        /// <param name="allowRedirects">
        /// Whether to follow HTTP redirects<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowInsecureSsl">
        /// Whether to bypass TLS certificate verification<br/>
        /// Default Value: false
        /// </param>
        /// <param name="proxies">
        /// Whether to enable proxy support for the request<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchCreateRequest(
            string url,
            bool? allowRedirects,
            bool? allowInsecureSsl,
            bool? proxies)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AllowRedirects = allowRedirects;
            this.AllowInsecureSsl = allowInsecureSsl;
            this.Proxies = proxies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateRequest" /> class.
        /// </summary>
        public FetchCreateRequest()
        {
        }
    }
}