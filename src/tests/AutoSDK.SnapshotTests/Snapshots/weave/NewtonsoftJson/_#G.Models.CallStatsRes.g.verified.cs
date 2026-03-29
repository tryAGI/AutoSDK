//HintName: G.Models.CallStatsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing time-series call statistics.
    /// </summary>
    public sealed partial class CallStatsRes
    {
        /// <summary>
        /// Resolved start time (UTC)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Start { get; set; } = default!;

        /// <summary>
        /// Resolved end time (UTC)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime End { get; set; } = default!;

        /// <summary>
        /// Bucket size used (in seconds)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("granularity", Required = global::Newtonsoft.Json.Required.Always)]
        public int Granularity { get; set; } = default!;

        /// <summary>
        /// Timezone used for bucket alignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timezone { get; set; } = default!;

        /// <summary>
        /// Usage metrics by model. Each bucket contains 'timestamp', 'model', and aggregated metric values.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_buckets")]
        public global::System.Collections.Generic.IList<object>? UsageBuckets { get; set; }

        /// <summary>
        /// Call-level metrics. Each bucket contains 'timestamp' and aggregated metric values.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_buckets")]
        public global::System.Collections.Generic.IList<object>? CallBuckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatsRes" /> class.
        /// </summary>
        /// <param name="start">
        /// Resolved start time (UTC)
        /// </param>
        /// <param name="end">
        /// Resolved end time (UTC)
        /// </param>
        /// <param name="granularity">
        /// Bucket size used (in seconds)
        /// </param>
        /// <param name="timezone">
        /// Timezone used for bucket alignment
        /// </param>
        /// <param name="usageBuckets">
        /// Usage metrics by model. Each bucket contains 'timestamp', 'model', and aggregated metric values.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="callBuckets">
        /// Call-level metrics. Each bucket contains 'timestamp' and aggregated metric values.<br/>
        /// Default Value: []
        /// </param>
        public CallStatsRes(
            global::System.DateTime start,
            global::System.DateTime end,
            int granularity,
            string timezone,
            global::System.Collections.Generic.IList<object>? usageBuckets,
            global::System.Collections.Generic.IList<object>? callBuckets)
        {
            this.Start = start;
            this.End = end;
            this.Granularity = granularity;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.UsageBuckets = usageBuckets;
            this.CallBuckets = callBuckets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatsRes" /> class.
        /// </summary>
        public CallStatsRes()
        {
        }
    }
}