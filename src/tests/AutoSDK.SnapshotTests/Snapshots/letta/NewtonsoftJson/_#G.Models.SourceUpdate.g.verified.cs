//HintName: G.Models.SourceUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for updating an existing Source.
    /// </summary>
    public sealed partial class SourceUpdate
    {
        /// <summary>
        /// The name of the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Instructions for how to use the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Metadata associated with the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The embedding configuration used by the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the source.
        /// </param>
        /// <param name="description">
        /// The description of the source.
        /// </param>
        /// <param name="instructions">
        /// Instructions for how to use the source.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the source.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the source.
        /// </param>
        public SourceUpdate(
            string? name,
            string? description,
            string? instructions,
            object? metadata,
            global::G.EmbeddingConfig? embeddingConfig)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.Metadata = metadata;
            this.EmbeddingConfig = embeddingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceUpdate" /> class.
        /// </summary>
        public SourceUpdate()
        {
        }
    }
}