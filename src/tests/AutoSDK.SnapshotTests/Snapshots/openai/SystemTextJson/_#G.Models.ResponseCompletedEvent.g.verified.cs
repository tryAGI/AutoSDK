//HintName: G.Models.ResponseCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the model response is complete.
    /// </summary>
    public sealed partial class ResponseCompletedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Response Response { get; set; }

        /// <summary>
        /// The type of the event. Always `response.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCompletedEventTypeJsonConverter))]
        public global::G.ResponseCompletedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCompletedEvent" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="type">
        /// The type of the event. Always `response.completed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCompletedEvent(
            global::G.Response response,
            global::G.ResponseCompletedEventType type)
        {
            this.Response = response;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCompletedEvent" /> class.
        /// </summary>
        public ResponseCompletedEvent()
        {
        }
    }
}