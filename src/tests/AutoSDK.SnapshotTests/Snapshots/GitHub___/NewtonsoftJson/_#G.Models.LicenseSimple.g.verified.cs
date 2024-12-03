//HintName: G.Models.LicenseSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// License Simple
    /// </summary>
    public sealed partial class LicenseSimple
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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::Newtonsoft.Json.JsonProperty("spdx_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SpdxId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LicenseSimple" /> class.
        /// </summary>
        /// <param name="key">
        /// Example: mit
        /// </param>
        /// <param name="name">
        /// Example: MIT License
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/licenses/mit
        /// </param>
        /// <param name="spdxId">
        /// Example: MIT
        /// </param>
        /// <param name="nodeId">
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </param>
        /// <param name="htmlUrl"></param>
        public LicenseSimple(
            string key,
            string name,
            string? url,
            string? spdxId,
            string nodeId,
            string? htmlUrl)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.SpdxId = spdxId ?? throw new global::System.ArgumentNullException(nameof(spdxId));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseSimple" /> class.
        /// </summary>
        public LicenseSimple()
        {
        }
    }
}