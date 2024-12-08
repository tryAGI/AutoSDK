//HintName: G.Models.PromptCachingBetaMessageStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCachingBetaMessageStartEvent
    {
        /// <summary>
        /// Default Value: message_start
        /// </summary>
        /// <default>global::G.PromptCachingBetaMessageStartEventType.MessageStart</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptCachingBetaMessageStartEventType Type { get; set; } = global::G.PromptCachingBetaMessageStartEventType.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptCachingBetaMessage Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaMessageStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_start
        /// </param>
        /// <param name="message"></param>
        public PromptCachingBetaMessageStartEvent(
            global::G.PromptCachingBetaMessage message,
            global::G.PromptCachingBetaMessageStartEventType type = global::G.PromptCachingBetaMessageStartEventType.MessageStart)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaMessageStartEvent" /> class.
        /// </summary>
        public PromptCachingBetaMessageStartEvent()
        {
        }
    }
}