//HintName: G.Models.MCPToolConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An MCP tool configuration that can be used to call MCP servers
    /// </summary>
    public sealed partial class MCPToolConfigInput
    {
        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of when the tool should be used and what it does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_pre_tool_speech")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallSoundBehaviorJsonConverter))]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_error_handling_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolErrorHandlingModeJsonConverter))]
        public global::G.ToolErrorHandlingMode? ToolErrorHandlingMode { get; set; }

        /// <summary>
        /// The type of MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Schema for any parameters the LLM needs to provide to the MCP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// The approval policy for the MCP tool<br/>
        /// Default Value: require_approval_all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPApprovalPolicyJsonConverter))]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// The name of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolName { get; set; }

        /// <summary>
        /// The description of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolDescription { get; set; }

        /// <summary>
        /// The id of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// The name of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Original inputSchema dict for consistent hashing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_input_schema")]
        public object? McpInputSchema { get; set; }

        /// <summary>
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolExecutionModeJsonConverter))]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Input parameter overrides for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_overrides")]
        public object? InputOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="name"></param>
        /// <param name="description">
        /// Description of when the tool should be used and what it does.
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
        /// <param name="integrationType">
        /// The type of MCP tool
        /// </param>
        /// <param name="parameters">
        /// Schema for any parameters the LLM needs to provide to the MCP tool.
        /// </param>
        /// <param name="approvalPolicy">
        /// The approval policy for the MCP tool<br/>
        /// Default Value: require_approval_all
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigInput(
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
            global::G.ObjectJsonSchemaPropertyInput? parameters,
            global::G.MCPApprovalPolicy? approvalPolicy,
            object? mcpInputSchema,
            global::G.ToolExecutionMode? executionMode,
            object? inputOverrides)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IntegrationType = integrationType;
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.McpToolDescription = mcpToolDescription ?? throw new global::System.ArgumentNullException(nameof(mcpToolDescription));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Type = type;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.DisableInterruptions = disableInterruptions;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.Assignments = assignments;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ToolErrorHandlingMode = toolErrorHandlingMode;
            this.Parameters = parameters;
            this.ApprovalPolicy = approvalPolicy;
            this.McpInputSchema = mcpInputSchema;
            this.ExecutionMode = executionMode;
            this.InputOverrides = inputOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        public MCPToolConfigInput()
        {
        }
    }
}