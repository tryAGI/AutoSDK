//HintName: G.Models.ArchivalMemorySearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArchivalMemorySearchResult
    {
        /// <summary>
        /// Unique identifier of the archival memory passage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp of when the memory was created, formatted in agent's timezone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Text content of the archival memory passage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// List of tags associated with this memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalMemorySearchResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the archival memory passage
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of when the memory was created, formatted in agent's timezone
        /// </param>
        /// <param name="content">
        /// Text content of the archival memory passage
        /// </param>
        /// <param name="tags">
        /// List of tags associated with this memory
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArchivalMemorySearchResult(
            string id,
            string timestamp,
            string content,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivalMemorySearchResult" /> class.
        /// </summary>
        public ArchivalMemorySearchResult()
        {
        }
    }
}