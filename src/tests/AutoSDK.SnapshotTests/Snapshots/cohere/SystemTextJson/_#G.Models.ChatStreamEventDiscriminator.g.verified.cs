//HintName: G.Models.ChatStreamEventDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEventDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatStreamEventDiscriminatorEventTypeJsonConverter))]
        public global::G.ChatStreamEventDiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEventDiscriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatStreamEventDiscriminator(
            global::G.ChatStreamEventDiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEventDiscriminator" /> class.
        /// </summary>
        public ChatStreamEventDiscriminator()
        {
        }
    }
}