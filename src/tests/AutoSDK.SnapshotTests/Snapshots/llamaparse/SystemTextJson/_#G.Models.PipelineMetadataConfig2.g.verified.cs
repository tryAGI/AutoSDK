//HintName: G.Models.PipelineMetadataConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineMetadataConfig2
    {
        /// <summary>
        /// List of metadata keys to exclude from embeddings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_embed_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedEmbedMetadataKeys { get; set; }

        /// <summary>
        /// List of metadata keys to exclude from LLM during retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_llm_metadata_keys")]
        public global::System.Collections.Generic.IList<string>? ExcludedLlmMetadataKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineMetadataConfig2" /> class.
        /// </summary>
        /// <param name="excludedEmbedMetadataKeys">
        /// List of metadata keys to exclude from embeddings
        /// </param>
        /// <param name="excludedLlmMetadataKeys">
        /// List of metadata keys to exclude from LLM during retrieval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineMetadataConfig2(
            global::System.Collections.Generic.IList<string>? excludedEmbedMetadataKeys,
            global::System.Collections.Generic.IList<string>? excludedLlmMetadataKeys)
        {
            this.ExcludedEmbedMetadataKeys = excludedEmbedMetadataKeys;
            this.ExcludedLlmMetadataKeys = excludedLlmMetadataKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineMetadataConfig2" /> class.
        /// </summary>
        public PipelineMetadataConfig2()
        {
        }
    }
}