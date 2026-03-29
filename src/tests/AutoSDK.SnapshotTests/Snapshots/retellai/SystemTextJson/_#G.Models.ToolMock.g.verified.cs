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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_match_rule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolMockInputMatchRuleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolMockInputMatchRule InputMatchRule { get; set; }

        /// <summary>
        /// The output of the tool call that will be fed into the LLM. Should be a JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// For tool calls like transfer_call that require a boolean result. Optional for most tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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