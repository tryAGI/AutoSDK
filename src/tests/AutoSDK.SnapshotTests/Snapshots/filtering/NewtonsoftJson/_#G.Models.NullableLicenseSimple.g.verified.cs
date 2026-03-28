//HintName: G.Models.NullableLicenseSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// License Simple
    /// </summary>
    public sealed partial class NullableLicenseSimple
    {
        /// <summary>
        /// Example: mit
        /// </summary>
        /// <example>mit</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Example: MIT License
        /// </summary>
        /// <example>MIT License</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/licenses/mit
        /// </summary>
        /// <example>https://api.github.com/licenses/mit</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::Newtonsoft.Json.JsonProperty("spdx_id")]
        public string? SpdxId { get; set; }

        /// <summary>
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </summary>
        /// <example>MDc6TGljZW5zZW1pdA==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableLicenseSimple" /> class.
        /// </summary>
        /// <param name="key">
        /// Example: mit
        /// </param>
        /// <param name="name">
        /// Example: MIT License
        /// </param>
        /// <param name="nodeId">
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/licenses/mit
        /// </param>
        /// <param name="spdxId">
        /// Example: MIT
        /// </param>
        /// <param name="htmlUrl"></param>
        public NullableLicenseSimple(
            string key,
            string name,
            string nodeId,
            string? url,
            string? spdxId,
            string? htmlUrl)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url;
            this.SpdxId = spdxId;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableLicenseSimple" /> class.
        /// </summary>
        public NullableLicenseSimple()
        {
        }
    }
}