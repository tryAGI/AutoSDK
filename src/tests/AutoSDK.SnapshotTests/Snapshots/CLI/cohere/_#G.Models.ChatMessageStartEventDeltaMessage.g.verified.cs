//HintName: G.Models.ChatMessageStartEventDeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventDeltaMessage
    {
        /// <summary>
        /// The role of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatMessageStartEventDeltaMessageRoleJsonConverter))]
        public global::G.ChatMessageStartEventDeltaMessageRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventDeltaMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessageStartEventDeltaMessage(
            global::G.ChatMessageStartEventDeltaMessageRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventDeltaMessage" /> class.
        /// </summary>
        public ChatMessageStartEventDeltaMessage()
        {
        }
    }
}