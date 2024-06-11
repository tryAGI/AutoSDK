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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of event. The string is in the form, hypetrain.{event\_name}. The request returns only progress event types (i.e., hypetrain.progression).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the event occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EventTimestamp { get; set; }

        /// <summary>
        /// The version number of the definition of the event’s data. For example, the value is 1 if the data in `event_data` uses the first definition of the event’s data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The event’s data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HypeTrainEventEventData EventData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}