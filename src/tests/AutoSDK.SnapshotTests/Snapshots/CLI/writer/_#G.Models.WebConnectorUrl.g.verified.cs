//HintName: G.Models.WebConnectorUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebConnectorUrl
    {
        /// <summary>
        /// The URL to be processed by the web connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The state of a web connector URL processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebConnectorUrlState Status { get; set; }

        /// <summary>
        /// An array of URLs to exclude from processing within this web connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_urls")]
        public global::System.Collections.Generic.IList<string>? ExcludeUrls { get; set; }

        /// <summary>
        /// The type of web connector processing for a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebConnectorUrlTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebConnectorUrlType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebConnectorUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to be processed by the web connector.
        /// </param>
        /// <param name="status">
        /// The state of a web connector URL processing.
        /// </param>
        /// <param name="type">
        /// The type of web connector processing for a URL.
        /// </param>
        /// <param name="excludeUrls">
        /// An array of URLs to exclude from processing within this web connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebConnectorUrl(
            string url,
            global::G.WebConnectorUrlState status,
            global::G.WebConnectorUrlType type,
            global::System.Collections.Generic.IList<string>? excludeUrls)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ExcludeUrls = excludeUrls;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebConnectorUrl" /> class.
        /// </summary>
        public WebConnectorUrl()
        {
        }
    }
}