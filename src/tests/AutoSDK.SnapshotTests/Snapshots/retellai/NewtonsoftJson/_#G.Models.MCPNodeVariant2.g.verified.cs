//HintName: G.Models.MCPNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPNodeVariant2TypeJsonConverter))]
        public global::G.MCPNodeVariant2Type Type { get; set; }

        /// <summary>
        /// Unique ID of the MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpId { get; set; } = default!;

        /// <summary>
        /// Name of the MCP tool to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.NodeEdge>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("else_edge")]
        public global::G.ElseEdge? ElseEdge { get; set; }

        /// <summary>
        /// Response variables to add to dynamic variables, key is the variable name, value is the path to the variable in the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseVariables { get; set; }

        /// <summary>
        /// If true, will speak during execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction")]
        public global::G.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// If true, will wait for result before transitioning to next node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wait_for_result", Required = global::Newtonsoft.Json.Required.Always)]
        public bool WaitForResult { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_transition_examples")]
        public global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? FinetuneTransitionExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPNodeVariant2" /> class.
        /// </summary>
        /// <param name="mcpId">
        /// Unique ID of the MCP server
        /// </param>
        /// <param name="mcpToolName">
        /// Name of the MCP tool to call
        /// </param>
        /// <param name="waitForResult">
        /// If true, will wait for result before transitioning to next node
        /// </param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="edges"></param>
        /// <param name="elseEdge"></param>
        /// <param name="responseVariables">
        /// Response variables to add to dynamic variables, key is the variable name, value is the path to the variable in the response
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution
        /// </param>
        /// <param name="instruction"></param>
        /// <param name="finetuneTransitionExamples"></param>
        public MCPNodeVariant2(
            string mcpId,
            string mcpToolName,
            bool waitForResult,
            global::G.MCPNodeVariant2Type type,
            global::System.Collections.Generic.IList<global::G.NodeEdge>? edges,
            global::G.ElseEdge? elseEdge,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            bool? speakDuringExecution,
            global::G.NodeInstruction? instruction,
            global::System.Collections.Generic.IList<global::G.NodeFinetuneTransitionExample>? finetuneTransitionExamples)
        {
            this.Type = type;
            this.McpId = mcpId ?? throw new global::System.ArgumentNullException(nameof(mcpId));
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.Edges = edges;
            this.ElseEdge = elseEdge;
            this.ResponseVariables = responseVariables;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
            this.WaitForResult = waitForResult;
            this.FinetuneTransitionExamples = finetuneTransitionExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPNodeVariant2" /> class.
        /// </summary>
        public MCPNodeVariant2()
        {
        }
    }
}