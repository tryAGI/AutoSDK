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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClientInboundMessageAddMessageType Type { get; set; }

        /// <summary>
        /// This is the message to add to the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIMessage Message { get; set; } = default!;

        /// <summary>
        /// This is the flag to trigger a response, or to insert the message into the conversation history silently. Defaults to `true`.<br/>
        /// Usage:<br/>
        /// - Use `true` to trigger a response.<br/>
        /// - Use `false` to insert the message into the conversation history silently.<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerResponseEnabled")]
        public bool? TriggerResponseEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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