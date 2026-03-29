//HintName: G.Models.TraceUsageRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response with per-call usage metrics (each includes descendant contributions).
    /// </summary>
    public sealed partial class TraceUsageRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_usage")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.LLMAggregatedUsage>>? CallUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unfinished_call_ids")]
        public global::System.Collections.Generic.IList<string>? UnfinishedCallIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceUsageRes" /> class.
        /// </summary>
        /// <param name="callUsage"></param>
        /// <param name="unfinishedCallIds"></param>
        public TraceUsageRes(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.LLMAggregatedUsage>>? callUsage,
            global::System.Collections.Generic.IList<string>? unfinishedCallIds)
        {
            this.CallUsage = callUsage;
            this.UnfinishedCallIds = unfinishedCallIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceUsageRes" /> class.
        /// </summary>
        public TraceUsageRes()
        {
        }
    }
}