//HintName: G.Models.PipelineTriggerChartRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PipelineTriggerChartRecord contains pipeline trigger metrics, aggregated by<br/>
    /// pipeline ID and time frame.
    /// </summary>
    public sealed partial class PipelineTriggerChartRecord
    {
        /// <summary>
        /// Pipeline ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Pipeline UUID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineUid")]
        public string? PipelineUid { get; set; }

        /// <summary>
        /// Trigger mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerMode")]
        public global::G.Mode? TriggerMode { get; set; }

        /// <summary>
        /// Final status.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// Time buckets.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeBuckets")]
        public global::System.Collections.Generic.IList<global::System.DateTime>? TimeBuckets { get; set; }

        /// <summary>
        /// Aggregated trigger count in each time bucket.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerCounts")]
        public global::System.Collections.Generic.IList<int>? TriggerCounts { get; set; }

        /// <summary>
        /// Total computation time duration in each time bucket.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("computeTimeDuration")]
        public global::System.Collections.Generic.IList<float>? ComputeTimeDuration { get; set; }

        /// <summary>
        /// Version for the triggered pipeline if it is a release pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineReleaseId")]
        public string? PipelineReleaseId { get; set; }

        /// <summary>
        /// Release UUID for the triggered pipeline if it is a release pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineReleaseUid")]
        public string? PipelineReleaseUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerChartRecord" /> class.
        /// </summary>
        /// <param name="pipelineId">
        /// Pipeline ID.
        /// </param>
        /// <param name="pipelineUid">
        /// Pipeline UUID.
        /// </param>
        /// <param name="triggerMode">
        /// Trigger mode.
        /// </param>
        /// <param name="status">
        /// Final status.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="timeBuckets">
        /// Time buckets.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="triggerCounts">
        /// Aggregated trigger count in each time bucket.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="computeTimeDuration">
        /// Total computation time duration in each time bucket.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineReleaseId">
        /// Version for the triggered pipeline if it is a release pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineReleaseUid">
        /// Release UUID for the triggered pipeline if it is a release pipeline.<br/>
        /// Included only in responses
        /// </param>
        public PipelineTriggerChartRecord(
            string? pipelineId,
            string? pipelineUid,
            global::G.Mode? triggerMode,
            global::G.Status? status,
            global::System.Collections.Generic.IList<global::System.DateTime>? timeBuckets,
            global::System.Collections.Generic.IList<int>? triggerCounts,
            global::System.Collections.Generic.IList<float>? computeTimeDuration,
            string? pipelineReleaseId,
            string? pipelineReleaseUid)
        {
            this.PipelineId = pipelineId;
            this.PipelineUid = pipelineUid;
            this.TriggerMode = triggerMode;
            this.Status = status;
            this.TimeBuckets = timeBuckets;
            this.TriggerCounts = triggerCounts;
            this.ComputeTimeDuration = computeTimeDuration;
            this.PipelineReleaseId = pipelineReleaseId;
            this.PipelineReleaseUid = pipelineReleaseUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerChartRecord" /> class.
        /// </summary>
        public PipelineTriggerChartRecord()
        {
        }
    }
}