//HintName: G.Models.ResponseToolUseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseToolUseBlock
    {
        /// <summary>
        /// Default Value: tool_use
        /// </summary>
        /// <default>global::G.ResponseToolUseBlockType.ToolUse</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseToolUseBlockType Type { get; set; } = global::G.ResponseToolUseBlockType.ToolUse;

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
        /// Initializes a new instance of the <see cref="ResponseToolUseBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tool_use
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="input"></param>
        public ResponseToolUseBlock(
            string id,
            string name,
            object input,
            global::G.ResponseToolUseBlockType type = global::G.ResponseToolUseBlockType.ToolUse)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolUseBlock" /> class.
        /// </summary>
        public ResponseToolUseBlock()
        {
        }
    }
}