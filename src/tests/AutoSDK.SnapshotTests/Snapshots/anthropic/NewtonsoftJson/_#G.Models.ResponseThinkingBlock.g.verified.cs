//HintName: G.Models.ResponseThinkingBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseThinkingBlock
    {
        /// <summary>
        /// Default Value: thinking
        /// </summary>
        /// <default>global::G.ResponseThinkingBlockType.Thinking</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseThinkingBlockType Type { get; set; } = global::G.ResponseThinkingBlockType.Thinking;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinking", Required = global::Newtonsoft.Json.Required.Always)]
        public string Thinking { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature", Required = global::Newtonsoft.Json.Required.Always)]
        public string Signature { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseThinkingBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: thinking
        /// </param>
        /// <param name="thinking"></param>
        /// <param name="signature"></param>
        public ResponseThinkingBlock(
            string thinking,
            string signature,
            global::G.ResponseThinkingBlockType type = global::G.ResponseThinkingBlockType.Thinking)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseThinkingBlock" /> class.
        /// </summary>
        public ResponseThinkingBlock()
        {
        }
    }
}