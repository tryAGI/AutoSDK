//HintName: G.Models.BetaResponseRedactedThinkingBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseRedactedThinkingBlock
    {
        /// <summary>
        /// Default Value: redacted_thinking
        /// </summary>
        /// <default>global::G.BetaResponseRedactedThinkingBlockType.RedactedThinking</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaResponseRedactedThinkingBlockTypeJsonConverter))]
        public global::G.BetaResponseRedactedThinkingBlockType Type { get; set; } = global::G.BetaResponseRedactedThinkingBlockType.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: redacted_thinking
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseRedactedThinkingBlock(
            string data,
            global::G.BetaResponseRedactedThinkingBlockType type = global::G.BetaResponseRedactedThinkingBlockType.RedactedThinking)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseRedactedThinkingBlock" /> class.
        /// </summary>
        public BetaResponseRedactedThinkingBlock()
        {
        }
    }
}