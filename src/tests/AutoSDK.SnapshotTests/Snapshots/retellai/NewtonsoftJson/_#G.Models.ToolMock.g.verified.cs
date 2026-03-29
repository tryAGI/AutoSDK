//HintName: G.Models.ToolMock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMock
    {
        /// <summary>
        /// Name of the tool to mock
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_match_rule", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolMockInputMatchRule InputMatchRule { get; set; } = default!;

        /// <summary>
        /// The output of the tool call that will be fed into the LLM. Should be a JSON string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string Output { get; set; } = default!;

        /// <summary>
        /// For tool calls like transfer_call that require a boolean result. Optional for most tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMock" /> class.
        /// </summary>
        /// <param name="toolName">
        /// Name of the tool to mock
        /// </param>
        /// <param name="inputMatchRule"></param>
        /// <param name="output">
        /// The output of the tool call that will be fed into the LLM. Should be a JSON string.
        /// </param>
        /// <param name="result">
        /// For tool calls like transfer_call that require a boolean result. Optional for most tools.
        /// </param>
        public ToolMock(
            string toolName,
            global::G.ToolMockInputMatchRule inputMatchRule,
            string output,
            bool? result)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.InputMatchRule = inputMatchRule;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMock" /> class.
        /// </summary>
        public ToolMock()
        {
        }
    }
}