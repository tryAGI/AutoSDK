//HintName: G.Models.MessageStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageStartEvent
    {
        /// <summary>
        /// Default Value: message_start
        /// </summary>
        /// <default>global::G.MessageStartEventType.MessageStart</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageStartEventTypeJsonConverter))]
        public global::G.MessageStartEventType Type { get; set; } = global::G.MessageStartEventType.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Message Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type">
        /// Default Value: message_start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageStartEvent(
            global::G.Message message,
            global::G.MessageStartEventType type = global::G.MessageStartEventType.MessageStart)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        public MessageStartEvent()
        {
        }
    }
}