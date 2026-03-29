//HintName: G.Models.AdvancedModeTransformConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdvancedModeTransformConfig
    {
        /// <summary>
        /// Default Value: advanced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Configuration for the segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.NoneSegmentationConfig, global::G.PageSegmentationConfig, global::G.ElementSegmentationConfig>))]
        public global::G.AnyOf<global::G.NoneSegmentationConfig, global::G.PageSegmentationConfig, global::G.ElementSegmentationConfig>? SegmentationConfig { get; set; }

        /// <summary>
        /// Configuration for the chunking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.NoneChunkingConfig, global::G.CharacterChunkingConfig, global::G.TokenChunkingConfig, global::G.SentenceChunkingConfig, global::G.SemanticChunkingConfig>))]
        public global::G.AnyOf<global::G.NoneChunkingConfig, global::G.CharacterChunkingConfig, global::G.TokenChunkingConfig, global::G.SentenceChunkingConfig, global::G.SemanticChunkingConfig>? ChunkingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedModeTransformConfig" /> class.
        /// </summary>
        /// <param name="mode">
        /// Default Value: advanced
        /// </param>
        /// <param name="segmentationConfig">
        /// Configuration for the segmentation.
        /// </param>
        /// <param name="chunkingConfig">
        /// Configuration for the chunking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvancedModeTransformConfig(
            string? mode,
            global::G.AnyOf<global::G.NoneSegmentationConfig, global::G.PageSegmentationConfig, global::G.ElementSegmentationConfig>? segmentationConfig,
            global::G.AnyOf<global::G.NoneChunkingConfig, global::G.CharacterChunkingConfig, global::G.TokenChunkingConfig, global::G.SentenceChunkingConfig, global::G.SemanticChunkingConfig>? chunkingConfig)
        {
            this.Mode = mode;
            this.SegmentationConfig = segmentationConfig;
            this.ChunkingConfig = chunkingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedModeTransformConfig" /> class.
        /// </summary>
        public AdvancedModeTransformConfig()
        {
        }
    }
}