//HintName: G.Models.BetaResponseToolUseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseToolUseBlock
    {
        /// <summary>
        /// Default Value: tool_use
        /// </summary>
        /// <default>global::G.BetaResponseToolUseBlockType.ToolUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaResponseToolUseBlockTypeJsonConverter))]
        public global::G.BetaResponseToolUseBlockType Type { get; set; } = global::G.BetaResponseToolUseBlockType.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolUseBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tool_use
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolUseBlock(
            string id,
            string name,
            object input,
            global::G.BetaResponseToolUseBlockType type = global::G.BetaResponseToolUseBlockType.ToolUse)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolUseBlock" /> class.
        /// </summary>
        public BetaResponseToolUseBlock()
        {
        }
    }
}