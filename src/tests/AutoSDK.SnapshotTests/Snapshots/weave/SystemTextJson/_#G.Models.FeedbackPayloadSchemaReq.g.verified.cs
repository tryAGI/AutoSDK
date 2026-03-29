//HintName: G.Models.FeedbackPayloadSchemaReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for feedback payload schema discovery.
    /// </summary>
    public sealed partial class FeedbackPayloadSchemaReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Inclusive start time (UTC, ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Filter by feedback_type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_type")]
        public string? FeedbackType { get; set; }

        /// <summary>
        /// Filter by trigger_ref (exact or prefix match for all-versions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_ref")]
        public string? TriggerRef { get; set; }

        /// <summary>
        /// Max distinct trigger_refs to sample when discovering the payload schema. Each distinct trigger_ref (monitor/source) typically has a fixed payload structure, so sampling one payload per ref is usually enough to see the full schema. 2 000 covers virtually all real-world projects while keeping the query fast; the hard cap of 5 000 prevents runaway scans.<br/>
        /// Default Value: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_limit")]
        public int? SampleLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackPayloadSchemaReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start">
        /// Inclusive start time (UTC, ISO 8601).
        /// </param>
        /// <param name="end">
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </param>
        /// <param name="feedbackType">
        /// Filter by feedback_type.
        /// </param>
        /// <param name="triggerRef">
        /// Filter by trigger_ref (exact or prefix match for all-versions).
        /// </param>
        /// <param name="sampleLimit">
        /// Max distinct trigger_refs to sample when discovering the payload schema. Each distinct trigger_ref (monitor/source) typically has a fixed payload structure, so sampling one payload per ref is usually enough to see the full schema. 2 000 covers virtually all real-world projects while keeping the query fast; the hard cap of 5 000 prevents runaway scans.<br/>
        /// Default Value: 2000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackPayloadSchemaReq(
            string projectId,
            global::System.DateTime start,
            global::System.DateTime? end,
            string? feedbackType,
            string? triggerRef,
            int? sampleLimit)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Start = start;
            this.End = end;
            this.FeedbackType = feedbackType;
            this.TriggerRef = triggerRef;
            this.SampleLimit = sampleLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackPayloadSchemaReq" /> class.
        /// </summary>
        public FeedbackPayloadSchemaReq()
        {
        }
    }
}