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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Deprecated: Use `embedding` field instead. Embedding configuration for the archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Embedding model handle for the archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="embedding">
        /// Embedding model handle for the archive
        /// </param>
        /// <param name="description"></param>
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