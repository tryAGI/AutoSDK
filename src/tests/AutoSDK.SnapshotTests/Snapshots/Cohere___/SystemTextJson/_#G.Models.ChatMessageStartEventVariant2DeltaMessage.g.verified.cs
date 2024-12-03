//HintName: G.Models.ChatMessageStartEventVariant2DeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventVariant2DeltaMessage
    {
        /// <summary>
        /// The role of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatMessageStartEventVariant2DeltaMessageRoleJsonConverter))]
        public global::G.ChatMessageStartEventVariant2DeltaMessageRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2DeltaMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatMessageStartEventVariant2DeltaMessage(
            global::G.ChatMessageStartEventVariant2DeltaMessageRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2DeltaMessage" /> class.
        /// </summary>
        public ChatMessageStartEventVariant2DeltaMessage()
        {
        }
    }
}