//HintName: G.Models.BetaThinkingContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaThinkingContentBlockDelta
    {
        /// <summary>
        /// Default Value: thinking_delta
        /// </summary>
        /// <default>global::G.BetaThinkingContentBlockDeltaType.ThinkingDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaThinkingContentBlockDeltaTypeJsonConverter))]
        public global::G.BetaThinkingContentBlockDeltaType Type { get; set; } = global::G.BetaThinkingContentBlockDeltaType.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: thinking_delta
        /// </param>
        /// <param name="thinking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThinkingContentBlockDelta(
            string thinking,
            global::G.BetaThinkingContentBlockDeltaType type = global::G.BetaThinkingContentBlockDeltaType.ThinkingDelta)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingContentBlockDelta" /> class.
        /// </summary>
        public BetaThinkingContentBlockDelta()
        {
        }
    }
}