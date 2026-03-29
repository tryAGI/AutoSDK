//HintName: G.Models.CallStatsReqGranularity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bucket size in seconds (e.g., 3600 for 1 hour). If omitted, auto-selected based on time range. Will be adjusted if it would produce more than 10,000 buckets.
    /// </summary>
    public sealed partial class CallStatsReqGranularity
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}