//HintName: G.Models.Blob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Blob
    /// </summary>
    public sealed partial class Blob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlighted_content")]
        public string? HighlightedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encoding"></param>
        /// <param name="url"></param>
        /// <param name="sha"></param>
        /// <param name="size"></param>
        /// <param name="nodeId"></param>
        /// <param name="highlightedContent"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Blob(
            string content,
            string encoding,
            string url,
            string sha,
            int? size,
            string nodeId,
            string? highlightedContent)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Size = size;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HighlightedContent = highlightedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        public Blob()
        {
        }
    }
}