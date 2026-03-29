//HintName: G.Models.Retriever.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An entity that retrieves context nodes from several sub RetrieverTools.
    /// </summary>
    public sealed partial class Retriever
    {
        /// <summary>
        /// A name for the retriever tool. Will default to the pipeline name if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The pipelines this retriever uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        public global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? Pipelines { get; set; }

        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the project this retriever resides in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Retriever" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the retriever tool. Will default to the pipeline name if not provided.
        /// </param>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="projectId">
        /// The ID of the project this retriever resides in.
        /// </param>
        /// <param name="pipelines">
        /// The pipelines this retriever uses.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Retriever(
            string name,
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.RetrieverPipeline>? pipelines,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pipelines = pipelines;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Retriever" /> class.
        /// </summary>
        public Retriever()
        {
        }
    }
}