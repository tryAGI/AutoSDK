//HintName: G.Models.UpdateGraphWebUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGraphWebUrl
    {
        /// <summary>
        /// The URL to be processed by the web connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// An array of URLs to exclude from processing within this web connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_urls")]
        public global::System.Collections.Generic.IList<string>? ExcludeUrls { get; set; }

        /// <summary>
        /// The type of web connector processing for a URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebConnectorUrlTypeJsonConverter))]
        public global::G.WebConnectorUrlType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGraphWebUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to be processed by the web connector.
        /// </param>
        /// <param name="type">
        /// The type of web connector processing for a URL.
        /// </param>
        /// <param name="excludeUrls">
        /// An array of URLs to exclude from processing within this web connector.
        /// </param>
        public UpdateGraphWebUrl(
            string url,
            global::G.WebConnectorUrlType type,
            global::System.Collections.Generic.IList<string>? excludeUrls)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExcludeUrls = excludeUrls;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGraphWebUrl" /> class.
        /// </summary>
        public UpdateGraphWebUrl()
        {
        }
    }
}