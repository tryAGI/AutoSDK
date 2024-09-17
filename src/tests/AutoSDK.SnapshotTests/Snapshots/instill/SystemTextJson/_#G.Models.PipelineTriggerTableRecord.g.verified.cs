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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Pipeline UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineUid")]
        public string? PipelineUid { get; set; }

        /// <summary>
        /// Number of triggers with `STATUS_COMPLETED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerCountCompleted")]
        public int TriggerCountCompleted { get; set; }

        /// <summary>
        /// Number of triggers with `STATUS_ERRORED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerCountErrored")]
        public int TriggerCountErrored { get; set; }

        /// <summary>
        /// Version for the triggered pipeline if it is a release pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineReleaseId")]
        public string? PipelineReleaseId { get; set; }

        /// <summary>
        /// Release UUID for the triggered pipeline if it is a release pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineReleaseUid")]
        public string? PipelineReleaseUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}