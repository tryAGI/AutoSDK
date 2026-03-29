//HintName: G.Models.PipelineConfigurationHashes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hashes for the configuration of a pipeline.
    /// </summary>
    public sealed partial class PipelineConfigurationHashes
    {
        /// <summary>
        /// Hash of the embedding config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config_hash")]
        public string? EmbeddingConfigHash { get; set; }

        /// <summary>
        /// Hash of the llama parse parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_config_hash")]
        public string? ParsingConfigHash { get; set; }

        /// <summary>
        /// Hash of the transform config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform_config_hash")]
        public string? TransformConfigHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineConfigurationHashes" /> class.
        /// </summary>
        /// <param name="embeddingConfigHash">
        /// Hash of the embedding config.
        /// </param>
        /// <param name="parsingConfigHash">
        /// Hash of the llama parse parameters.
        /// </param>
        /// <param name="transformConfigHash">
        /// Hash of the transform config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineConfigurationHashes(
            string? embeddingConfigHash,
            string? parsingConfigHash,
            string? transformConfigHash)
        {
            this.EmbeddingConfigHash = embeddingConfigHash;
            this.ParsingConfigHash = parsingConfigHash;
            this.TransformConfigHash = transformConfigHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineConfigurationHashes" /> class.
        /// </summary>
        public PipelineConfigurationHashes()
        {
        }
    }
}