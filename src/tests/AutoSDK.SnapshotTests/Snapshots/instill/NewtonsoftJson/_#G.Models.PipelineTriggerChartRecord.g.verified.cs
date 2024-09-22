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
        public global::G.Mgmtv1betaStatus? Status { get; set; }

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
    }
}