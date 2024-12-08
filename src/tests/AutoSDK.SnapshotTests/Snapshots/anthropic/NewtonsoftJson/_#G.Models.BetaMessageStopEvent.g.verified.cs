//HintName: G.Models.BetaMessageStopEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageStopEvent
    {
        /// <summary>
        /// Default Value: message_stop
        /// </summary>
        /// <default>global::G.BetaMessageStopEventType.MessageStop</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaMessageStopEventType Type { get; set; } = global::G.BetaMessageStopEventType.MessageStop;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageStopEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_stop
        /// </param>
        public BetaMessageStopEvent(
            global::G.BetaMessageStopEventType type = global::G.BetaMessageStopEventType.MessageStop)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageStopEvent" /> class.
        /// </summary>
        public BetaMessageStopEvent()
        {
        }
    }
}