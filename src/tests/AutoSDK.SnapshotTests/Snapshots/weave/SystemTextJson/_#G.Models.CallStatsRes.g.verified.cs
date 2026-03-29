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
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Resolved end time (UTC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// Bucket size used (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Granularity { get; set; }

        /// <summary>
        /// Timezone used for bucket alignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Usage metrics by model. Each bucket contains 'timestamp', 'model', and aggregated metric values.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_buckets")]
        public global::System.Collections.Generic.IList<object>? UsageBuckets { get; set; }

        /// <summary>
        /// Call-level metrics. Each bucket contains 'timestamp' and aggregated metric values.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_buckets")]
        public global::System.Collections.Generic.IList<object>? CallBuckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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