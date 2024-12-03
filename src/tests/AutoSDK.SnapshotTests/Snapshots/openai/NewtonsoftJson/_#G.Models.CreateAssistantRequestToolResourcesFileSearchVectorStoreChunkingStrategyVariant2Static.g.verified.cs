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
        /// The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_chunk_size_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxChunkSizeTokens { get; set; } = default!;

        /// <summary>
        /// The number of tokens that overlap between chunks. The default value is `400`.<br/>
        /// Note that the overlap must not exceed half of `max_chunk_size_tokens`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_overlap_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkOverlapTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static" /> class.
        /// </summary>
        /// <param name="maxChunkSizeTokens">
        /// The maximum number of tokens in each chunk. The default value is `800`. The minimum value is `100` and the maximum value is `4096`.
        /// </param>
        /// <param name="chunkOverlapTokens">
        /// The number of tokens that overlap between chunks. The default value is `400`.<br/>
        /// Note that the overlap must not exceed half of `max_chunk_size_tokens`.
        /// </param>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static(
            int maxChunkSizeTokens,
            int chunkOverlapTokens)
        {
            this.MaxChunkSizeTokens = maxChunkSizeTokens;
            this.ChunkOverlapTokens = chunkOverlapTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static" /> class.
        /// </summary>
        public CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Static()
        {
        }
    }
}