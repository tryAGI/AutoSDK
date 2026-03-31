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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The store identifier to apply the rule to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// The type of substitution
        /// </summary>
        /// <default>"file_search_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file_search_result";

        /// <summary>
        /// The file ID of the file to substitute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// An optional chunk index to use for the chunk substitution<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// The index where the result will be inserted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResultIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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