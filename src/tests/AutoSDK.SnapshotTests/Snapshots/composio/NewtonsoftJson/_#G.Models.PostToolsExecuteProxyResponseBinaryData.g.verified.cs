//HintName: G.Models.PostToolsExecuteProxyResponseBinaryData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Binary body response data. Present when the response is a binary file.
    /// </summary>
    public sealed partial class PostToolsExecuteProxyResponseBinaryData
    {
        /// <summary>
        /// URL to download binary content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Content-Type of the binary data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public double Size { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp when the URL expires
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyResponseBinaryData" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to download binary content
        /// </param>
        /// <param name="contentType">
        /// Content-Type of the binary data
        /// </param>
        /// <param name="size">
        /// File size in bytes
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 timestamp when the URL expires
        /// </param>
        public PostToolsExecuteProxyResponseBinaryData(
            string url,
            string contentType,
            double size,
            string? expiresAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Size = size;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyResponseBinaryData" /> class.
        /// </summary>
        public PostToolsExecuteProxyResponseBinaryData()
        {
        }
    }
}