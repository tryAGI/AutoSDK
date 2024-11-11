//HintName: G.Models.PingEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ping event in a streaming conversation.
    /// </summary>
    public sealed partial class PingEvent
    {
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
        /// Initializes a new instance of the <see cref="PingEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        public PingEvent(
            global::G.MessageStreamEventType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingEvent" /> class.
        /// </summary>
        public PingEvent()
        {
        }
    }
}