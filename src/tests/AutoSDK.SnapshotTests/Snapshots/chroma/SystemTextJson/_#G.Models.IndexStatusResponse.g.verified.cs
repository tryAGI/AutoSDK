//HintName: G.Models.IndexStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_indexed_ops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long NumIndexedOps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_unindexed_ops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long NumUnindexedOps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_indexing_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float OpIndexingProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_ops")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalOps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatusResponse" /> class.
        /// </summary>
        /// <param name="numIndexedOps"></param>
        /// <param name="numUnindexedOps"></param>
        /// <param name="opIndexingProgress"></param>
        /// <param name="totalOps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexStatusResponse(
            long numIndexedOps,
            long numUnindexedOps,
            float opIndexingProgress,
            long totalOps)
        {
            this.NumIndexedOps = numIndexedOps;
            this.NumUnindexedOps = numUnindexedOps;
            this.OpIndexingProgress = opIndexingProgress;
            this.TotalOps = totalOps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatusResponse" /> class.
        /// </summary>
        public IndexStatusResponse()
        {
        }
    }
}