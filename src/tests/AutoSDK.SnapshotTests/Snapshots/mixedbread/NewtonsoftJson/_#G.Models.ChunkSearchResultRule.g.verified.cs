//HintName: G.Models.ChunkSearchResultRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a chunk search result rule for a vector store search.
    /// </summary>
    public sealed partial class ChunkSearchResultRule
    {
        /// <summary>
        /// The query to trigger the rule
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The store identifier to apply the rule to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// The type of substitution
        /// </summary>
        /// <default>"chunk_search_result"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "chunk_search_result";

        /// <summary>
        /// The file ID of the chunk to substitute
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The index of the chunk to substitute
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// The index where the result will be inserted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ResultIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkSearchResultRule" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to trigger the rule
        /// </param>
        /// <param name="storeId">
        /// The store identifier to apply the rule to
        /// </param>
        /// <param name="fileId">
        /// The file ID of the chunk to substitute
        /// </param>
        /// <param name="chunkIndex">
        /// The index of the chunk to substitute
        /// </param>
        /// <param name="resultIndex">
        /// The index where the result will be inserted
        /// </param>
        /// <param name="type">
        /// The type of substitution
        /// </param>
        public ChunkSearchResultRule(
            string query,
            string storeId,
            string fileId,
            int chunkIndex,
            int resultIndex,
            string type = "chunk_search_result")
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.ChunkIndex = chunkIndex;
            this.ResultIndex = resultIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkSearchResultRule" /> class.
        /// </summary>
        public ChunkSearchResultRule()
        {
        }
    }
}