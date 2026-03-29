//HintName: G.Models.LlmTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmTool
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.LlmToolType Type { get; set; }

        /// <summary>
        /// A tool that uses another Writer model to generate a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LlmFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmTool" /> class.
        /// </summary>
        /// <param name="function">
        /// A tool that uses another Writer model to generate a response.
        /// </param>
        /// <param name="type">
        /// The type of tool.
        /// </param>
        public LlmTool(
            global::G.LlmFunction function,
            global::G.LlmToolType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmTool" /> class.
        /// </summary>
        public LlmTool()
        {
        }
    }
}