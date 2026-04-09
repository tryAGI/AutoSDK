//HintName: G.Models.MCPToolConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An MCP tool configuration that can be used to call MCP servers
    /// </summary>
    public sealed partial class MCPToolConfigOutput
    {
        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of when the tool should be used and what it does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force_pre_tool_speech")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignments")]
        public global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_sound_behavior")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallSoundBehaviorJsonConverter))]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_error_handling_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolErrorHandlingModeJsonConverter))]
        public global::G.ToolErrorHandlingMode? ToolErrorHandlingMode { get; set; }

        /// <summary>
        /// The type of MCP tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.IntegrationTypeJsonConverter))]
        public global::G.IntegrationType IntegrationType { get; set; } = default!;

        /// <summary>
        /// Schema for any parameters the LLM needs to provide to the MCP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ObjectJsonSchemaPropertyOutput? Parameters { get; set; }

        /// <summary>
        /// The approval policy for the MCP tool<br/>
        /// Default Value: require_approval_all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPApprovalPolicyJsonConverter))]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// The name of the MCP tool to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpToolName { get; set; } = default!;

        /// <summary>
        /// The description of the MCP tool to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpToolDescription { get; set; } = default!;

        /// <summary>
        /// The id of the MCP server to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerId { get; set; } = default!;

        /// <summary>
        /// The name of the MCP server to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerName { get; set; } = default!;

        /// <summary>
        /// Original inputSchema dict for consistent hashing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_input_schema")]
        public object? McpInputSchema { get; set; }

        /// <summary>
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolExecutionModeJsonConverter))]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Input parameter overrides for this tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_overrides")]
        public object? InputOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description">
        /// Description of when the tool should be used and what it does.
        /// </param>
        /// <param name="integrationType">
        /// The type of MCP tool
        /// </param>
        /// <param name="mcpToolName">
        /// The name of the MCP tool to call
        /// </param>
        /// <param name="mcpToolDescription">
        /// The description of the MCP tool to call
        /// </param>
        /// <param name="mcpServerId">
        /// The id of the MCP server to call
        /// </param>
        /// <param name="mcpServerName">
        /// The name of the MCP server to call
        /// </param>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="disableInterruptions">
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="forcePreToolSpeech">
        /// If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="assignments">
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="toolErrorHandlingMode">
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="parameters">
        /// Schema for any parameters the LLM needs to provide to the MCP tool.
        /// </param>
        /// <param name="approvalPolicy">
        /// The approval policy for the MCP tool<br/>
        /// Default Value: require_approval_all
        /// </param>
        /// <param name="mcpInputSchema">
        /// Original inputSchema dict for consistent hashing
        /// </param>
        /// <param name="executionMode">
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </param>
        /// <param name="inputOverrides">
        /// Input parameter overrides for this tool
        /// </param>
        public MCPToolConfigOutput(
            string name,
            string description,
            global::G.IntegrationType integrationType,
            string mcpToolName,
            string mcpToolDescription,
            string mcpServerId,
            string mcpServerName,
            string? type,
            int? responseTimeoutSecs,
            bool? disableInterruptions,
            bool? forcePreToolSpeech,
            global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? assignments,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::G.ToolErrorHandlingMode? toolErrorHandlingMode,
            global::G.ObjectJsonSchemaPropertyOutput? parameters,
            global::G.MCPApprovalPolicy? approvalPolicy,
            object? mcpInputSchema,
            global::G.ToolExecutionMode? executionMode,
            object? inputOverrides)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.DisableInterruptions = disableInterruptions;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.Assignments = assignments;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ToolErrorHandlingMode = toolErrorHandlingMode;
            this.IntegrationType = integrationType;
            this.Parameters = parameters;
            this.ApprovalPolicy = approvalPolicy;
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.McpToolDescription = mcpToolDescription ?? throw new global::System.ArgumentNullException(nameof(mcpToolDescription));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.McpInputSchema = mcpInputSchema;
            this.ExecutionMode = executionMode;
            this.InputOverrides = inputOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutput" /> class.
        /// </summary>
        public MCPToolConfigOutput()
        {
        }
    }
}