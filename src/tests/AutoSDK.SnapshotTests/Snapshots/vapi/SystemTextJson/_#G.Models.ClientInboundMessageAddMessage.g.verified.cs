//HintName: G.Models.ClientInboundMessageAddMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageAddMessage
    {
        /// <summary>
        /// This is the type of the message. Send "add-message" message to add a message to the conversation history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClientInboundMessageAddMessageTypeJsonConverter))]
        public global::G.ClientInboundMessageAddMessageType Type { get; set; }

        /// <summary>
        /// This is the message to add to the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIMessage Message { get; set; }

        /// <summary>
        /// This is the flag to trigger a response, or to insert the message into the conversation history silently. Defaults to `true`.<br/>
        /// Usage:<br/>
        /// - Use `true` to trigger a response.<br/>
        /// - Use `false` to insert the message into the conversation history silently.<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerResponseEnabled")]
        public bool? TriggerResponseEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageAddMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the message to add to the conversation.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. Send "add-message" message to add a message to the conversation history.
        /// </param>
        /// <param name="triggerResponseEnabled">
        /// This is the flag to trigger a response, or to insert the message into the conversation history silently. Defaults to `true`.<br/>
        /// Usage:<br/>
        /// - Use `true` to trigger a response.<br/>
        /// - Use `false` to insert the message into the conversation history silently.<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInboundMessageAddMessage(
            global::G.OpenAIMessage message,
            global::G.ClientInboundMessageAddMessageType type,
            bool? triggerResponseEnabled)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.TriggerResponseEnabled = triggerResponseEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageAddMessage" /> class.
        /// </summary>
        public ClientInboundMessageAddMessage()
        {
        }
    }
}