//HintName: G.Models.BetaRequestThinkingBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaRequestThinkingBlockTypeJsonConverter))]
        public global::G.BetaRequestThinkingBlockType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaRequestThinkingBlock" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="signature"></param>
        /// <param name="type"></param>
        public BetaRequestThinkingBlock(
            string thinking,
            string signature,
            global::G.BetaRequestThinkingBlockType type)
        {
            this.Type = type;
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestThinkingBlock" /> class.
        /// </summary>
        public BetaRequestThinkingBlock()
        {
        }
    }
}