//HintName: G.Models.EventsListResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventsListResponseResult
    {
        /// <summary>
        /// The unique identifier of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The type of event (e.g., ADD, SEARCH).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// The current status of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EventsListResponseResultStatusJsonConverter))]
        public global::G.EventsListResponseResultStatus? Status { get; set; }

        /// <summary>
        /// The original payload associated with the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Additional metadata associated with the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Array of results produced by the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public byte[]? Results { get; set; }

        /// <summary>
        /// Timestamp when the event was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the event was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp when event processing started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Timestamp when event processing completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Processing time in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsListResponseResult" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the event.
        /// </param>
        /// <param name="eventType">
        /// The type of event (e.g., ADD, SEARCH).
        /// </param>
        /// <param name="status">
        /// The current status of the event.
        /// </param>
        /// <param name="payload">
        /// The original payload associated with the event.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the event.
        /// </param>
        /// <param name="results">
        /// Array of results produced by the event.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the event was last updated.
        /// </param>
        /// <param name="startedAt">
        /// Timestamp when event processing started.
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when event processing completed.
        /// </param>
        /// <param name="latency">
        /// Processing time in milliseconds.
        /// </param>
        public EventsListResponseResult(
            global::System.Guid? id,
            string? eventType,
            global::G.EventsListResponseResultStatus? status,
            object? payload,
            object? metadata,
            byte[]? results,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            double? latency)
        {
            this.Id = id;
            this.EventType = eventType;
            this.Status = status;
            this.Payload = payload;
            this.Metadata = metadata;
            this.Results = results;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Latency = latency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsListResponseResult" /> class.
        /// </summary>
        public EventsListResponseResult()
        {
        }
    }
}