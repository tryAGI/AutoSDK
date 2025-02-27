//HintName: G.Models.RequestThinkingBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestThinkingBlockType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestThinkingBlock" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="thinking"></param>
        /// <param name="signature"></param>
        public RequestThinkingBlock(
            string thinking,
            string signature,
            global::G.RequestThinkingBlockType type)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestThinkingBlock" /> class.
        /// </summary>
        public RequestThinkingBlock()
        {
        }
    }
}