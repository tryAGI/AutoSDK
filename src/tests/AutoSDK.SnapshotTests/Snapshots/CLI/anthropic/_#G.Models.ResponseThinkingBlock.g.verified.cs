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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseThinkingBlockTypeJsonConverter))]
        public global::G.ResponseThinkingBlockType Type { get; set; } = global::G.ResponseThinkingBlockType.Thinking;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseThinkingBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: thinking
        /// </param>
        /// <param name="thinking"></param>
        /// <param name="signature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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