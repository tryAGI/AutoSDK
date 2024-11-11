//HintName: G.Models.PipelineTriggerRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PipelineTriggerRecord represents a pipeline execution event.
    /// </summary>
    public sealed partial class PipelineTriggerRecord
    {
        /// <summary>
        /// The moment when the pipeline was triggered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerTime")]
        public global::System.DateTime? TriggerTime { get; set; }

        /// <summary>
        /// UUID of the trigger.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineTriggerId")]
        public string? PipelineTriggerId { get; set; }

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
        /// Total execution duration.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("computeTimeDuration")]
        public float? ComputeTimeDuration { get; set; }

        /// <summary>
        /// Final status.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// If a release of the pipeline was triggered, pipeline version.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineReleaseId")]
        public string? PipelineReleaseId { get; set; }

        /// <summary>
        /// If a release of the pipeline was triggered, release UUID.<br/>
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
        /// Initializes a new instance of the <see cref="PipelineTriggerRecord" /> class.
        /// </summary>
        /// <param name="triggerTime">
        /// The moment when the pipeline was triggered.
        /// </param>
        /// <param name="pipelineTriggerId">
        /// UUID of the trigger.
        /// </param>
        /// <param name="pipelineId">
        /// Pipeline ID.
        /// </param>
        /// <param name="pipelineUid">
        /// Pipeline UUID.
        /// </param>
        /// <param name="triggerMode">
        /// Trigger mode.
        /// </param>
        /// <param name="computeTimeDuration">
        /// Total execution duration.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Final status.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineReleaseId">
        /// If a release of the pipeline was triggered, pipeline version.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineReleaseUid">
        /// If a release of the pipeline was triggered, release UUID.<br/>
        /// Included only in responses
        /// </param>
        public PipelineTriggerRecord(
            global::System.DateTime? triggerTime,
            string? pipelineTriggerId,
            string? pipelineId,
            string? pipelineUid,
            global::G.Mode? triggerMode,
            float? computeTimeDuration,
            global::G.Status? status,
            string? pipelineReleaseId,
            string? pipelineReleaseUid)
        {
            this.TriggerTime = triggerTime;
            this.PipelineTriggerId = pipelineTriggerId;
            this.PipelineId = pipelineId;
            this.PipelineUid = pipelineUid;
            this.TriggerMode = triggerMode;
            this.ComputeTimeDuration = computeTimeDuration;
            this.Status = status;
            this.PipelineReleaseId = pipelineReleaseId;
            this.PipelineReleaseUid = pipelineReleaseUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerRecord" /> class.
        /// </summary>
        public PipelineTriggerRecord()
        {
        }
    }
}