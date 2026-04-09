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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaResponseRedactedThinkingBlockTypeJsonConverter))]
        public global::G.BetaResponseRedactedThinkingBlockType Type { get; set; } = global::G.BetaResponseRedactedThinkingBlockType.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// Default Value: redacted_thinking
        /// </param>
        public BetaResponseRedactedThinkingBlock(
            string data,
            global::G.BetaResponseRedactedThinkingBlockType type = global::G.BetaResponseRedactedThinkingBlockType.RedactedThinking)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseRedactedThinkingBlock" /> class.
        /// </summary>
        public BetaResponseRedactedThinkingBlock()
        {
        }
    }
}