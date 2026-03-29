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
        [global::Newtonsoft.Json.JsonProperty("num_indexed_ops", Required = global::Newtonsoft.Json.Required.Always)]
        public long NumIndexedOps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_unindexed_ops", Required = global::Newtonsoft.Json.Required.Always)]
        public long NumUnindexedOps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op_indexing_progress", Required = global::Newtonsoft.Json.Required.Always)]
        public float OpIndexingProgress { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_ops", Required = global::Newtonsoft.Json.Required.Always)]
        public long TotalOps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatusResponse" /> class.
        /// </summary>
        /// <param name="numIndexedOps"></param>
        /// <param name="numUnindexedOps"></param>
        /// <param name="opIndexingProgress"></param>
        /// <param name="totalOps"></param>
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