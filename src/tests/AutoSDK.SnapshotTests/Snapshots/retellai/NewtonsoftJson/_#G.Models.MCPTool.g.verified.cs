//HintName: G.Models.MCPTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPToolTypeJsonConverter))]
        public global::G.MCPToolType Type { get; set; }

        /// <summary>
        /// Unique id of the MCP.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_id")]
        public string? McpId { get; set; }

        /// <summary>
        /// Name of the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The input schema of the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema")]
        public global::System.Collections.Generic.Dictionary<string, string>? InputSchema { get; set; }

        /// <summary>
        /// Response variables to add to dynamic variables, key is the variable name, value is the path to the variable in the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseVariables { get; set; }

        /// <summary>
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the function. Recommend to turn on if your function call takes over 1s (including network) to complete, so that your agent remains responsive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained. Usually this needs to get turned on so user can get update for the function call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_after_execution")]
        public bool? SpeakAfterExecution { get; set; }

        /// <summary>
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true. Can write what to say or even provide examples. The default is "The message you will say to callee when calling this tool. Make sure it fits into the conversation smoothly.".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_description")]
        public string? ExecutionMessageDescription { get; set; }

        /// <summary>
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_message_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPToolExecutionMessageTypeJsonConverter))]
        public global::G.MCPToolExecutionMessageType? ExecutionMessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the MCP tool.
        /// </param>
        /// <param name="description">
        /// Description of the MCP tool.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpId">
        /// Unique id of the MCP.
        /// </param>
        /// <param name="inputSchema">
        /// The input schema of the MCP tool.
        /// </param>
        /// <param name="responseVariables">
        /// Response variables to add to dynamic variables, key is the variable name, value is the path to the variable in the response
        /// </param>
        /// <param name="speakDuringExecution">
        /// Determines whether the agent would say sentence like "One moment, let me check that." when executing the function. Recommend to turn on if your function call takes over 1s (including network) to complete, so that your agent remains responsive.
        /// </param>
        /// <param name="speakAfterExecution">
        /// Determines whether the agent would call LLM another time and speak when the result of function is obtained. Usually this needs to get turned on so user can get update for the function call.
        /// </param>
        /// <param name="executionMessageDescription">
        /// The description for the sentence agent say during execution. Only applicable when speak_during_execution is true. Can write what to say or even provide examples. The default is "The message you will say to callee when calling this tool. Make sure it fits into the conversation smoothly.".
        /// </param>
        /// <param name="executionMessageType">
        /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
        /// </param>
        public MCPTool(
            string name,
            string description,
            global::G.MCPToolType type,
            string? mcpId,
            global::System.Collections.Generic.Dictionary<string, string>? inputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? responseVariables,
            bool? speakDuringExecution,
            bool? speakAfterExecution,
            string? executionMessageDescription,
            global::G.MCPToolExecutionMessageType? executionMessageType)
        {
            this.Type = type;
            this.McpId = mcpId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema;
            this.ResponseVariables = responseVariables;
            this.SpeakDuringExecution = speakDuringExecution;
            this.SpeakAfterExecution = speakAfterExecution;
            this.ExecutionMessageDescription = executionMessageDescription;
            this.ExecutionMessageType = executionMessageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        public MCPTool()
        {
        }
    }
}