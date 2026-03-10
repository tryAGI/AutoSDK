//HintName: G.Models.MCPServerConfigUpdateRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unified request model for updating MCP Server configuration.
    /// </summary>
    public sealed partial class MCPServerConfigUpdateRequestModel
    {
        /// <summary>
        /// The approval mode to set for the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// If set, overrides the server's force_pre_tool_speech setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_pre_tool_speech")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play for all tools from this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// If set, overrides the server's execution_mode setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// The headers to include in requests to the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Whether to disable HTTP compression for this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_compression")]
        public bool? DisableCompression { get; set; }

        /// <summary>
        /// Optional secret token for authentication with this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_token")]
        public global::G.ConvAISecretLocator? SecretToken { get; set; }

        /// <summary>
        /// Optional auth connection to use for authentication with this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_connection")]
        public global::G.AuthConnectionLocator? AuthConnection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigUpdateRequestModel" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// The approval mode to set for the MCP server
        /// </param>
        /// <param name="forcePreToolSpeech">
        /// If set, overrides the server's force_pre_tool_speech setting for this tool
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play for all tools from this MCP server
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="requestHeaders">
        /// The headers to include in requests to the MCP server
        /// </param>
        /// <param name="disableCompression">
        /// Whether to disable HTTP compression for this MCP server
        /// </param>
        /// <param name="secretToken">
        /// Optional secret token for authentication with this MCP server
        /// </param>
        /// <param name="authConnection">
        /// Optional auth connection to use for authentication with this MCP server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerConfigUpdateRequestModel(
            global::G.MCPApprovalPolicy? approvalPolicy,
            bool? forcePreToolSpeech,
            bool? disableInterruptions,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::G.ToolExecutionMode? executionMode,
            object? requestHeaders,
            bool? disableCompression,
            global::G.ConvAISecretLocator? secretToken,
            global::G.AuthConnectionLocator? authConnection)
        {
            this.ApprovalPolicy = approvalPolicy;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.DisableInterruptions = disableInterruptions;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ExecutionMode = executionMode;
            this.RequestHeaders = requestHeaders;
            this.DisableCompression = disableCompression;
            this.SecretToken = secretToken;
            this.AuthConnection = authConnection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigUpdateRequestModel" /> class.
        /// </summary>
        public MCPServerConfigUpdateRequestModel()
        {
        }
    }
}