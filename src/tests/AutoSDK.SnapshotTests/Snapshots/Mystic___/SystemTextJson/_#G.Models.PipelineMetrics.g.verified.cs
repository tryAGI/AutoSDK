//HintName: G.Models.PipelineMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PipelineName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Pointers { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_failed_at")]
        public global::System.DateTime? LastFailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_compute_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AvgComputeTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_compute_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalComputeTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineMetrics" /> class.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pipelineName"></param>
        /// <param name="pointers"></param>
        /// <param name="runCount"></param>
        /// <param name="failedRunCount"></param>
        /// <param name="lastRunAt"></param>
        /// <param name="lastFailedAt"></param>
        /// <param name="avgComputeTimeMs"></param>
        /// <param name="totalComputeTimeMs"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineMetrics(
            string pipelineId,
            string pipelineName,
            global::System.Collections.Generic.IList<string> pointers,
            int runCount,
            int failedRunCount,
            int avgComputeTimeMs,
            int totalComputeTimeMs,
            global::System.DateTime? lastRunAt,
            global::System.DateTime? lastFailedAt)
        {
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.PipelineName = pipelineName ?? throw new global::System.ArgumentNullException(nameof(pipelineName));
            this.Pointers = pointers ?? throw new global::System.ArgumentNullException(nameof(pointers));
            this.RunCount = runCount;
            this.FailedRunCount = failedRunCount;
            this.AvgComputeTimeMs = avgComputeTimeMs;
            this.TotalComputeTimeMs = totalComputeTimeMs;
            this.LastRunAt = lastRunAt;
            this.LastFailedAt = lastFailedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineMetrics" /> class.
        /// </summary>
        public PipelineMetrics()
        {
        }
    }
}