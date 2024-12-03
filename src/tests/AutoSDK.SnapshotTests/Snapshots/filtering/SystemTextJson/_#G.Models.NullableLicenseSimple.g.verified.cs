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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Example: MIT License
        /// </summary>
        /// <example>MIT License</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: https://api.github.com/licenses/mit
        /// </summary>
        /// <example>https://api.github.com/licenses/mit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Url { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdx_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SpdxId { get; set; }

        /// <summary>
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </summary>
        /// <example>MDc6TGljZW5zZW1pdA==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NullableLicenseSimple(
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
        /// Initializes a new instance of the <see cref="NullableLicenseSimple" /> class.
        /// </summary>
        public NullableLicenseSimple()
        {
        }
    }
}