//HintName: G.Models.PipelineTriggerTableRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PipelineTriggerTableRecord contains pipeline trigger metrics, aggregated by<br/>
    /// pipeline ID.
    /// </summary>
    public sealed partial class PipelineTriggerTableRecord
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
        /// Number of triggers with `STATUS_COMPLETED`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerCountCompleted")]
        public int? TriggerCountCompleted { get; set; }

        /// <summary>
        /// Number of triggers with `STATUS_ERRORED`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerCountErrored")]
        public int? TriggerCountErrored { get; set; }

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