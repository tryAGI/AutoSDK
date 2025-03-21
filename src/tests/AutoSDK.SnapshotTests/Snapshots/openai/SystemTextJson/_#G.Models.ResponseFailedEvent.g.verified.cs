//HintName: G.Models.ResponseFailedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An event that is emitted when a response fails.
    /// </summary>
    public sealed partial class ResponseFailedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFailedEventTypeJsonConverter))]
        public global::G.ResponseFailedEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Response Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFailedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.failed`.
        /// </param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFailedEvent(
            global::G.Response response,
            global::G.ResponseFailedEventType type)
        {
            this.Response = response;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFailedEvent" /> class.
        /// </summary>
        public ResponseFailedEvent()
        {
        }
    }
}