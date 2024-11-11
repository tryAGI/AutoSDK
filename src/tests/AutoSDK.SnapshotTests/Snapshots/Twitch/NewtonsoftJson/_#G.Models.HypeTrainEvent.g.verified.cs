//HintName: G.Models.HypeTrainEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HypeTrainEvent
    {
        /// <summary>
        /// An ID that identifies this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of event. The string is in the form, hypetrain.{event\_name}. The request returns only progress event types (i.e., hypetrain.progression).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the event occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EventTimestamp { get; set; } = default!;

        /// <summary>
        /// The version number of the definition of the event’s data. For example, the value is 1 if the data in `event_data` uses the first definition of the event’s data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The event’s data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HypeTrainEventEventData EventData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this event.
        /// </param>
        /// <param name="eventType">
        /// The type of event. The string is in the form, hypetrain.{event\_name}. The request returns only progress event types (i.e., hypetrain.progression).
        /// </param>
        /// <param name="eventTimestamp">
        /// The UTC date and time (in RFC3339 format) that the event occurred.
        /// </param>
        /// <param name="version">
        /// The version number of the definition of the event’s data. For example, the value is 1 if the data in `event_data` uses the first definition of the event’s data.
        /// </param>
        /// <param name="eventData">
        /// The event’s data.
        /// </param>
        public HypeTrainEvent(
            string id,
            string eventType,
            global::System.DateTime eventTimestamp,
            string version,
            global::G.HypeTrainEventEventData eventData)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.EventTimestamp = eventTimestamp;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.EventData = eventData ?? throw new global::System.ArgumentNullException(nameof(eventData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainEvent" /> class.
        /// </summary>
        public HypeTrainEvent()
        {
        }
    }
}