//HintName: G.Models.EmbeddingModelConfigUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingModelConfigUpdate
    {
        /// <summary>
        /// The name of the embedding model config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The embedding configuration for the embedding model config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        public global::G.EmbeddingConfigVariant1? EmbeddingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfigUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the embedding model config.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the embedding model config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingModelConfigUpdate(
            string? name,
            global::G.EmbeddingConfigVariant1? embeddingConfig)
        {
            this.Name = name;
            this.EmbeddingConfig = embeddingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfigUpdate" /> class.
        /// </summary>
        public EmbeddingModelConfigUpdate()
        {
        }
    }
}