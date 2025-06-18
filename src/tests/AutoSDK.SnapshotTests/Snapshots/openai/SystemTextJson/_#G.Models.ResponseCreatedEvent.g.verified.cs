//HintName: G.Models.ResponseCreatedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An event that is emitted when a response is created.
    /// </summary>
    public sealed partial class ResponseCreatedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCreatedEventTypeJsonConverter))]
        public global::G.ResponseCreatedEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Response Response { get; set; }

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.created`.
        /// </param>
        /// <param name="response"></param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCreatedEvent(
            global::G.Response response,
            int sequenceNumber,
            global::G.ResponseCreatedEventType type)
        {
            this.Response = response;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatedEvent" /> class.
        /// </summary>
        public ResponseCreatedEvent()
        {
        }
    }
}