//HintName: G.Models.Passage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a passage, which is stored in archival memory.
    /// </summary>
    public sealed partial class Passage
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The creation date of the passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Whether this passage is deleted or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// The unique identifier of the archive containing this passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_id")]
        public string? ArchiveId { get; set; }

        /// <summary>
        /// Deprecated: Use `folder_id` field instead. The data source of the passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The unique identifier of the file associated with the passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The name of the file (only for source passages).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// The metadata of the passage.<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Tags associated with this passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The human-friendly ID of the Passage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The text of the passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The embedding of the passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// The embedding configuration used by the passage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Passage" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the passage.
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="createdAt">
        /// The creation date of the passage.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="isDeleted">
        /// Whether this passage is deleted or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="archiveId">
        /// The unique identifier of the archive containing this passage.
        /// </param>
        /// <param name="fileId">
        /// The unique identifier of the file associated with the passage.
        /// </param>
        /// <param name="fileName">
        /// The name of the file (only for source passages).
        /// </param>
        /// <param name="metadata">
        /// The metadata of the passage.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="tags">
        /// Tags associated with this passage.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Passage
        /// </param>
        /// <param name="embedding">
        /// The embedding of the passage.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the passage.
        /// </param>
        public Passage(
            string text,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            bool? isDeleted,
            string? archiveId,
            string? fileId,
            string? fileName,
            object? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            string? id,
            global::System.Collections.Generic.IList<double>? embedding,
            global::G.EmbeddingConfig? embeddingConfig)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsDeleted = isDeleted;
            this.ArchiveId = archiveId;
            this.FileId = fileId;
            this.FileName = fileName;
            this.Metadata = metadata;
            this.Tags = tags;
            this.Id = id;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Embedding = embedding;
            this.EmbeddingConfig = embeddingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Passage" /> class.
        /// </summary>
        public Passage()
        {
        }
    }
}