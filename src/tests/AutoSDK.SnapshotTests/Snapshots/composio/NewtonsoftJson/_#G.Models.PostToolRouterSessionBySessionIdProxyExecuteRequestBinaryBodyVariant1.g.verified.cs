//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1
    {
        /// <summary>
        /// URL to fetch binary content from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Content-Type header to use for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to fetch binary content from
        /// </param>
        /// <param name="contentType">
        /// Content-Type header to use for the request
        /// </param>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1(
            string url,
            string? contentType)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1()
        {
        }
    }
}