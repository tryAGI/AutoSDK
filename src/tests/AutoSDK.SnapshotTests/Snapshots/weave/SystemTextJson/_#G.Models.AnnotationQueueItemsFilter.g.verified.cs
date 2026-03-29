//HintName: G.Models.AnnotationQueueItemsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Simple filter for annotation queue items.<br/>
    /// Supports equality filtering on call metadata fields and IN filtering on annotation state.
    /// </summary>
    public sealed partial class AnnotationQueueItemsFilter
    {
        /// <summary>
        /// Filter by exact queue item ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Filter by exact call ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Filter by exact operation name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_op_name")]
        public string? CallOpName { get; set; }

        /// <summary>
        /// Filter by exact trace ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_trace_id")]
        public string? CallTraceId { get; set; }

        /// <summary>
        /// Filter by W&amp;B user ID who added the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_by")]
        public string? AddedBy { get; set; }

        /// <summary>
        /// Filter by annotation states (unstarted, in_progress, completed, skipped)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_states")]
        public global::System.Collections.Generic.IList<global::G.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? AnnotationStates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsFilter" /> class.
        /// </summary>
        /// <param name="id">
        /// Filter by exact queue item ID
        /// </param>
        /// <param name="callId">
        /// Filter by exact call ID
        /// </param>
        /// <param name="callOpName">
        /// Filter by exact operation name
        /// </param>
        /// <param name="callTraceId">
        /// Filter by exact trace ID
        /// </param>
        /// <param name="addedBy">
        /// Filter by W&amp;B user ID who added the call
        /// </param>
        /// <param name="annotationStates">
        /// Filter by annotation states (unstarted, in_progress, completed, skipped)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueItemsFilter(
            string? id,
            string? callId,
            string? callOpName,
            string? callTraceId,
            string? addedBy,
            global::System.Collections.Generic.IList<global::G.AnnotationQueueItemsFilterAnnotationStatesVariant1Item>? annotationStates)
        {
            this.Id = id;
            this.CallId = callId;
            this.CallOpName = callOpName;
            this.CallTraceId = callTraceId;
            this.AddedBy = addedBy;
            this.AnnotationStates = annotationStates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemsFilter" /> class.
        /// </summary>
        public AnnotationQueueItemsFilter()
        {
        }
    }
}