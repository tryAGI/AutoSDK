//HintName: G.Models.FileSearchResultRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a file search result rule for a vector store search.
    /// </summary>
    public sealed partial class FileSearchResultRule
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
        /// <default>"file_search_result"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "file_search_result";

        /// <summary>
        /// The file ID of the file to substitute
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// An optional chunk index to use for the chunk substitution<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_index")]
        public int? ChunkIndex { get; set; }

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
        /// Initializes a new instance of the <see cref="FileSearchResultRule" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to trigger the rule
        /// </param>
        /// <param name="storeId">
        /// The store identifier to apply the rule to
        /// </param>
        /// <param name="fileId">
        /// The file ID of the file to substitute
        /// </param>
        /// <param name="resultIndex">
        /// The index where the result will be inserted
        /// </param>
        /// <param name="chunkIndex">
        /// An optional chunk index to use for the chunk substitution<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="type">
        /// The type of substitution
        /// </param>
        public FileSearchResultRule(
            string query,
            string storeId,
            string fileId,
            int resultIndex,
            int? chunkIndex,
            string type = "file_search_result")
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.ChunkIndex = chunkIndex;
            this.ResultIndex = resultIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchResultRule" /> class.
        /// </summary>
        public FileSearchResultRule()
        {
        }
    }
}