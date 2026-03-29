//HintName: G.Models.BaseEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseEvent
    {
        /// <summary>
        /// UUID v4 that identifies the event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Datetime (ISO 8601) of event creation in client. Should be as close to actual event creation in client as possible, this timestamp will be used for ordering of events in future release. Resolution: milliseconds (required), microseconds (optimal).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID v4 that identifies the event
        /// </param>
        /// <param name="timestamp">
        /// Datetime (ISO 8601) of event creation in client. Should be as close to actual event creation in client as possible, this timestamp will be used for ordering of events in future release. Resolution: milliseconds (required), microseconds (optimal).
        /// </param>
        /// <param name="metadata">
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </param>
        public BaseEvent(
            string id,
            string timestamp,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEvent" /> class.
        /// </summary>
        public BaseEvent()
        {
        }
    }
}