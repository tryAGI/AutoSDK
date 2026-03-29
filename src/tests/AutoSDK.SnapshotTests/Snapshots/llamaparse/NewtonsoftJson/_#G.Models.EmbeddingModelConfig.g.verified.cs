//HintName: G.Models.EmbeddingModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an embedding model config.
    /// </summary>
    public sealed partial class EmbeddingModelConfig
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The name of the embedding model config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The embedding configuration for the embedding model config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingConfig EmbeddingConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="name">
        /// The name of the embedding model config.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the embedding model config.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        public EmbeddingModelConfig(
            global::System.Guid id,
            string name,
            global::G.EmbeddingConfig embeddingConfig,
            global::System.Guid projectId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EmbeddingConfig = embeddingConfig;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfig" /> class.
        /// </summary>
        public EmbeddingModelConfig()
        {
        }
    }
}