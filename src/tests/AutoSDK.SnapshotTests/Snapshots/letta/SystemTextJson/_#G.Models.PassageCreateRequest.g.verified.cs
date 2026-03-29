//HintName: G.Models.PassageCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for creating a passage in an archive.
    /// </summary>
    public sealed partial class PassageCreateRequest
    {
        /// <summary>
        /// The text content of the passage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Optional metadata for the passage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Optional tags for categorizing the passage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Optional creation datetime for the passage (ISO 8601 format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageCreateRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content of the passage
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the passage
        /// </param>
        /// <param name="tags">
        /// Optional tags for categorizing the passage
        /// </param>
        /// <param name="createdAt">
        /// Optional creation datetime for the passage (ISO 8601 format)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassageCreateRequest(
            string text,
            object? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            string? createdAt)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Metadata = metadata;
            this.Tags = tags;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageCreateRequest" /> class.
        /// </summary>
        public PassageCreateRequest()
        {
        }
    }
}