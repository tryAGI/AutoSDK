//HintName: G.Models.RealtimeServerEventError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an error occurs, which could be a client problem or a server <br/>
    /// problem. Most errors are recoverable and the session will stay open, we <br/>
    /// recommend to implementors to monitor and log error messages by default.
    /// </summary>
    public sealed partial class RealtimeServerEventError
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventErrorTypeJsonConverter))]
        public global::G.RealtimeServerEventErrorType Type { get; set; }

        /// <summary>
        /// Details of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeServerEventErrorError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventError" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `error`.
        /// </param>
        /// <param name="error">
        /// Details of the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventError(
            string eventId,
            global::G.RealtimeServerEventErrorError error,
            global::G.RealtimeServerEventErrorType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventError" /> class.
        /// </summary>
        public RealtimeServerEventError()
        {
        }
    }
}