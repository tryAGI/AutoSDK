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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptCachingBetaMessageStartEventTypeJsonConverter))]
        public global::G.PromptCachingBetaMessageStartEventType Type { get; set; } = global::G.PromptCachingBetaMessageStartEventType.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptCachingBetaMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaMessageStartEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_start
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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