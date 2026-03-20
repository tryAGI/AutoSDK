//HintName: G.Models.ResponseDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response has completed.
    /// </summary>
    public sealed partial class ResponseDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseDoneEventTypeJsonConverter))]
        public global::G.ResponseDoneEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Response information from the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.ResponseInfo? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDoneEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="response">
        /// Response information from the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseDoneEvent(
            global::G.ResponseDoneEventType? type,
            string? eventId,
            global::G.ResponseInfo? response)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDoneEvent" /> class.
        /// </summary>
        public ResponseDoneEvent()
        {
        }
    }
}