//HintName: G.Models.BetaMessageStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageStartEvent
    {
        /// <summary>
        /// Default Value: message_start
        /// </summary>
        /// <default>global::G.BetaMessageStartEventType.MessageStart</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaMessageStartEventType Type { get; set; } = global::G.BetaMessageStartEventType.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BetaMessage Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_start
        /// </param>
        /// <param name="message"></param>
        public BetaMessageStartEvent(
            global::G.BetaMessage message,
            global::G.BetaMessageStartEventType type = global::G.BetaMessageStartEventType.MessageStart)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageStartEvent" /> class.
        /// </summary>
        public BetaMessageStartEvent()
        {
        }
    }
}