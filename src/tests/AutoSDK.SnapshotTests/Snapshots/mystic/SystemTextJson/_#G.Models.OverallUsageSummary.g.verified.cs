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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedRunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_compute_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalComputeTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_run_count_change")]
        public double? SuccessfulRunCountChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_run_count_change")]
        public double? FailedRunCountChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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