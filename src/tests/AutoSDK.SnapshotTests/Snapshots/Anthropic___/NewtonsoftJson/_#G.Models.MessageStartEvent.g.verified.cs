//HintName: G.Models.MessageStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A start event in a streaming conversation.
    /// </summary>
    public sealed partial class MessageStartEvent
    {
        /// <summary>
        /// A message in a chat conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Message Message { get; set; } = default!;

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        /// <param name="message">
        /// A message in a chat conversation.
        /// </param>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        public MessageStartEvent(
            global::G.Message message,
            global::G.MessageStreamEventType type)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        public MessageStartEvent()
        {
        }
    }
}