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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The state of a web connector URL processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebConnectorUrlState Status { get; set; } = default!;

        /// <summary>
        /// An array of URLs to exclude from processing within this web connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_urls")]
        public global::System.Collections.Generic.IList<string>? ExcludeUrls { get; set; }

        /// <summary>
        /// The type of web connector processing for a URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebConnectorUrlType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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