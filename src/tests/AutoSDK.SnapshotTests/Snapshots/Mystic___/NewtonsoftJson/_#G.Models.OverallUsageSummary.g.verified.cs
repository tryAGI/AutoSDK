//HintName: G.Models.OverallUsageSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class OverallUsageSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedRunCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_compute_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalComputeTimeMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successful_run_count_change")]
        public double? SuccessfulRunCountChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_run_count_change")]
        public double? FailedRunCountChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OverallUsageSummary" /> class.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="runCount"></param>
        /// <param name="failedRunCount"></param>
        /// <param name="totalComputeTimeMs"></param>
        /// <param name="successfulRunCountChange"></param>
        /// <param name="failedRunCountChange"></param>
        public OverallUsageSummary(
            double start,
            double end,
            int runCount,
            int failedRunCount,
            int totalComputeTimeMs,
            string? pipelineId,
            double? successfulRunCountChange,
            double? failedRunCountChange)
        {
            this.Start = start;
            this.End = end;
            this.RunCount = runCount;
            this.FailedRunCount = failedRunCount;
            this.TotalComputeTimeMs = totalComputeTimeMs;
            this.PipelineId = pipelineId;
            this.SuccessfulRunCountChange = successfulRunCountChange;
            this.FailedRunCountChange = failedRunCountChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverallUsageSummary" /> class.
        /// </summary>
        public OverallUsageSummary()
        {
        }
    }
}