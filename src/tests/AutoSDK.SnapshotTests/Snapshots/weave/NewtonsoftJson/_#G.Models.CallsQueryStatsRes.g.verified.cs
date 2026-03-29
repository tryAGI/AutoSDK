//HintName: G.Models.CallsQueryStatsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallsQueryStatsRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_storage_size_bytes")]
        public long? TotalStorageSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsQueryStatsRes" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="totalStorageSizeBytes"></param>
        public CallsQueryStatsRes(
            int count,
            long? totalStorageSizeBytes)
        {
            this.Count = count;
            this.TotalStorageSizeBytes = totalStorageSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsQueryStatsRes" /> class.
        /// </summary>
        public CallsQueryStatsRes()
        {
        }
    }
}