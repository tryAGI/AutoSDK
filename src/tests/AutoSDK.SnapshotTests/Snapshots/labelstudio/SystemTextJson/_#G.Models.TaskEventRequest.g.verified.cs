//HintName: G.Models.TaskEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for TaskEvent model to handle event creation from frontend.<br/>
    /// This serializer validates and processes task events sent from the labeling interface,<br/>
    /// ensuring proper data format and automatically setting required relationships.
    /// </summary>
    public sealed partial class TaskEventRequest
    {
        /// <summary>
        /// Annotation ID associated with this event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        public int? Annotation { get; set; }

        /// <summary>
        /// Draft annotation ID associated with this event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_draft_id")]
        public int? AnnotationDraftId { get; set; }

        /// <summary>
        /// Event type identifier (e.g., "annotation_loaded", "region_finished_drawing")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventKey { get; set; }

        /// <summary>
        /// Timestamp when the event occurred (frontend time)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EventTime { get; set; }

        /// <summary>
        /// Additional event metadata (region data, hotkey info, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Review ID associated with this event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        public int? Review { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEventRequest" /> class.
        /// </summary>
        /// <param name="eventKey">
        /// Event type identifier (e.g., "annotation_loaded", "region_finished_drawing")
        /// </param>
        /// <param name="eventTime">
        /// Timestamp when the event occurred (frontend time)
        /// </param>
        /// <param name="annotation">
        /// Annotation ID associated with this event
        /// </param>
        /// <param name="annotationDraftId">
        /// Draft annotation ID associated with this event
        /// </param>
        /// <param name="meta">
        /// Additional event metadata (region data, hotkey info, etc.)
        /// </param>
        /// <param name="review">
        /// Review ID associated with this event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskEventRequest(
            string eventKey,
            global::System.DateTime eventTime,
            int? annotation,
            int? annotationDraftId,
            object? meta,
            int? review)
        {
            this.Annotation = annotation;
            this.AnnotationDraftId = annotationDraftId;
            this.EventKey = eventKey ?? throw new global::System.ArgumentNullException(nameof(eventKey));
            this.EventTime = eventTime;
            this.Meta = meta;
            this.Review = review;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEventRequest" /> class.
        /// </summary>
        public TaskEventRequest()
        {
        }
    }
}