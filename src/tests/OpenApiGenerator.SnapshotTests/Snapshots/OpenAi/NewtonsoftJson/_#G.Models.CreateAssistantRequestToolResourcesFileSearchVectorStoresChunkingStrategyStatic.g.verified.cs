//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyStatic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyStatic
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
    }
}