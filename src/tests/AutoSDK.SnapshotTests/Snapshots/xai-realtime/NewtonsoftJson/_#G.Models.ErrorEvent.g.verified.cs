//HintName: G.Models.ErrorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An error occurred.
    /// </summary>
    public sealed partial class ErrorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ErrorEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.RealtimeError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="error">
        /// Error details.
        /// </param>
        public ErrorEvent(
            global::G.ErrorEventType? type,
            string? eventId,
            global::G.RealtimeError? error)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        public ErrorEvent()
        {
        }
    }
}