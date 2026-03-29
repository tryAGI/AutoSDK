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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Content-Type of the binary data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when the URL expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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