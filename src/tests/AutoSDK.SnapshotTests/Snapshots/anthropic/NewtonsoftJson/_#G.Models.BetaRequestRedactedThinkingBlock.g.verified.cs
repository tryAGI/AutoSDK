//HintName: G.Models.BetaRequestRedactedThinkingBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestRedactedThinkingBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaRequestRedactedThinkingBlockTypeJsonConverter))]
        public global::G.BetaRequestRedactedThinkingBlockType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaRequestRedactedThinkingBlock" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public BetaRequestRedactedThinkingBlock(
            string data,
            global::G.BetaRequestRedactedThinkingBlockType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestRedactedThinkingBlock" /> class.
        /// </summary>
        public BetaRequestRedactedThinkingBlock()
        {
        }
    }
}