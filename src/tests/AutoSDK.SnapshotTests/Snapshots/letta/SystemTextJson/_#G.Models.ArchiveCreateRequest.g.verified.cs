//HintName: G.Models.ArchiveCreateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for creating an archive.<br/>
    /// Intentionally excludes vector_db_provider. These are derived internally (vector DB provider from env).
    /// </summary>
    public sealed partial class ArchiveCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Deprecated: Use `embedding` field instead. Embedding configuration for the archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Embedding model handle for the archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="embedding">
        /// Embedding model handle for the archive
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArchiveCreateRequest(
            string name,
            string? embedding,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Embedding = embedding;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveCreateRequest" /> class.
        /// </summary>
        public ArchiveCreateRequest()
        {
        }
    }
}