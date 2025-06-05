//HintName: G.Models.TimeDeploymentStatsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeDeploymentStatsOut
    {
        /// <summary>
        /// number of inference requests in the provided interval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public int Requests { get; set; } = default!;

        /// <summary>
        /// total number of seconds spend in inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_time_s", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTimeS { get; set; } = default!;

        /// <summary>
        /// total number of cents spent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_amount_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalAmountCents { get; set; } = default!;

        /// <summary>
        /// average millisecond inference time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double AvgTimeMs { get; set; } = default!;

        /// <summary>
        /// 95th percentile inference time (estimated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg95_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double Avg95TimeMs { get; set; } = default!;

        /// <summary>
        /// number of errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public int Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDeploymentStatsOut" /> class.
        /// </summary>
        /// <param name="requests">
        /// number of inference requests in the provided interval
        /// </param>
        /// <param name="totalTimeS">
        /// total number of seconds spend in inference
        /// </param>
        /// <param name="totalAmountCents">
        /// total number of cents spent
        /// </param>
        /// <param name="avgTimeMs">
        /// average millisecond inference time
        /// </param>
        /// <param name="avg95TimeMs">
        /// 95th percentile inference time (estimated)
        /// </param>
        /// <param name="errors">
        /// number of errors
        /// </param>
        public TimeDeploymentStatsOut(
            int requests,
            int totalTimeS,
            int totalAmountCents,
            double avgTimeMs,
            double avg95TimeMs,
            int errors)
        {
            this.Requests = requests;
            this.TotalTimeS = totalTimeS;
            this.TotalAmountCents = totalAmountCents;
            this.AvgTimeMs = avgTimeMs;
            this.Avg95TimeMs = avg95TimeMs;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDeploymentStatsOut" /> class.
        /// </summary>
        public TimeDeploymentStatsOut()
        {
        }
    }
}