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
        [global::Newtonsoft.Json.JsonProperty("annotation")]
        public int? Annotation { get; set; }

        /// <summary>
        /// Draft annotation ID associated with this event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_draft_id")]
        public int? AnnotationDraftId { get; set; }

        /// <summary>
        /// Event type identifier (e.g., "annotation_loaded", "region_finished_drawing")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventKey { get; set; } = default!;

        /// <summary>
        /// Timestamp when the event occurred (frontend time)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EventTime { get; set; } = default!;

        /// <summary>
        /// Additional event metadata (region data, hotkey info, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Review ID associated with this event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review")]
        public int? Review { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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