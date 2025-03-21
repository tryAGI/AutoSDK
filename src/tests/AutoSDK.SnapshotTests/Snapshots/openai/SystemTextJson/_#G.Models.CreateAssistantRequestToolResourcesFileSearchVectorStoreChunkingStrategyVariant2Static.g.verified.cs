//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static
    {
        /// <summary>
        /// The number of tokens that overlap between chunks. The default value is `400`.<br/>
        /// Note that the overlap must not exceed half of `max_chunk_size_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_overlap_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkOverlapTokens { get; set; }

        /// <summary>
        /// The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunk_size_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxChunkSizeTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static" /> class.
        /// </summary>
        /// <param name="chunkOverlapTokens">
        /// The number of tokens that overlap between chunks. The default value is `400`.<br/>
        /// Note that the overlap must not exceed half of `max_chunk_size_tokens`.
        /// </param>
        /// <param name="maxChunkSizeTokens">
        /// The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static(
            int chunkOverlapTokens,
            int maxChunkSizeTokens)
        {
            this.ChunkOverlapTokens = chunkOverlapTokens;
            this.MaxChunkSizeTokens = maxChunkSizeTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static" /> class.
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static()
        {
        }
    }
}