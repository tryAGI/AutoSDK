//HintName: G.Models.ReportChunkBatchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportChunkBatchResponse
    {
        /// <summary>
        /// The URL for accessing your asset. The platform returns this field only when all chunks are reported and the upload is complete. If absent, continue uploading and reporting the remaining chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The unique identifier of this asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The number of chunks accepted from this specific request. This equals the number of chunks in your `completed_chunks` array minus any duplicates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_chunks")]
        public int? ProcessedChunks { get; set; }

        /// <summary>
        /// The number of chunks in this request that were already reported. Duplicates are ignored and don't affect your upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicate_chunks")]
        public int? DuplicateChunks { get; set; }

        /// <summary>
        /// The cumulative count of all unique chunks successfully reported across all requests. When this equals `total_chunks`, the upload is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_completed")]
        public int? TotalCompleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportChunkBatchResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL for accessing your asset. The platform returns this field only when all chunks are reported and the upload is complete. If absent, continue uploading and reporting the remaining chunks.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of this asset.
        /// </param>
        /// <param name="processedChunks">
        /// The number of chunks accepted from this specific request. This equals the number of chunks in your `completed_chunks` array minus any duplicates.
        /// </param>
        /// <param name="duplicateChunks">
        /// The number of chunks in this request that were already reported. Duplicates are ignored and don't affect your upload.
        /// </param>
        /// <param name="totalCompleted">
        /// The cumulative count of all unique chunks successfully reported across all requests. When this equals `total_chunks`, the upload is complete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportChunkBatchResponse(
            string? url,
            string? assetId,
            int? processedChunks,
            int? duplicateChunks,
            int? totalCompleted)
        {
            this.Url = url;
            this.AssetId = assetId;
            this.ProcessedChunks = processedChunks;
            this.DuplicateChunks = duplicateChunks;
            this.TotalCompleted = totalCompleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportChunkBatchResponse" /> class.
        /// </summary>
        public ReportChunkBatchResponse()
        {
        }
    }
}