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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageStartEventType Type { get; set; } = global::G.MessageStartEventType.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Message Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_start
        /// </param>
        /// <param name="message"></param>
        public MessageStartEvent(
            global::G.Message message,
            global::G.MessageStartEventType type = global::G.MessageStartEventType.MessageStart)
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