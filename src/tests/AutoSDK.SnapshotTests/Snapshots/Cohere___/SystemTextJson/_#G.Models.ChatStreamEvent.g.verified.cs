//HintName: G.Models.ChatStreamEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatStreamEventEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatStreamEventEventType EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEvent" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatStreamEvent(
            global::G.ChatStreamEventEventType eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEvent" /> class.
        /// </summary>
        public ChatStreamEvent()
        {
        }
    }
}