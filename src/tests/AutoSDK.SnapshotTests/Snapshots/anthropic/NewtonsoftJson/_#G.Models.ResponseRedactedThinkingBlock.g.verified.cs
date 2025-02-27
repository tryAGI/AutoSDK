//HintName: G.Models.ResponseRedactedThinkingBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseRedactedThinkingBlock
    {
        /// <summary>
        /// Default Value: redacted_thinking
        /// </summary>
        /// <default>global::G.ResponseRedactedThinkingBlockType.RedactedThinking</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseRedactedThinkingBlockType Type { get; set; } = global::G.ResponseRedactedThinkingBlockType.RedactedThinking;

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
        /// Initializes a new instance of the <see cref="ResponseRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: redacted_thinking
        /// </param>
        /// <param name="data"></param>
        public ResponseRedactedThinkingBlock(
            string data,
            global::G.ResponseRedactedThinkingBlockType type = global::G.ResponseRedactedThinkingBlockType.RedactedThinking)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRedactedThinkingBlock" /> class.
        /// </summary>
        public ResponseRedactedThinkingBlock()
        {
        }
    }
}