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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaResponseToolUseBlockType Type { get; set; } = global::G.BetaResponseToolUseBlockType.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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