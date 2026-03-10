//HintName: G.Models.MCPServerConfigOutput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerConfigOutput
    {
        /// <summary>
        /// Defines the MCP server-level approval policy for tool execution.<br/>
        /// Default Value: require_approval_all
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy")]
        public global::G.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// List of tool approval hashes for per-tool approval when approval_policy is REQUIRE_APPROVAL_PER_TOOL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_approval_hashes")]
        public global::System.Collections.Generic.IList<global::G.MCPToolApprovalHash>? ToolApprovalHashes { get; set; }

        /// <summary>
        /// The transport type used to connect to the MCP server<br/>
        /// Default Value: SSE
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.MCPServerTransport? Transport { get; set; }

        /// <summary>
        /// The URL of the MCP server, if this contains a secret please store as a workspace secret, otherwise store as a plain string. Must use https
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.ConvAISecretLocator> Url { get; set; } = default!;

        /// <summary>
        /// The secret token (Authorization header) stored as a workspace secret or in-place secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_token")]
        public global::G.AnyOf<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>? SecretToken { get; set; }

        /// <summary>
        /// The headers included in the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// Optional auth connection to use for authentication with this MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_connection")]
        public global::G.AuthConnectionLocator? AuthConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// If true, all tools from this MCP server will require pre-tool execution speech<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force_pre_tool_speech")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while any tool from this MCP server is running.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play for all tools from this MCP server<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_sound_behavior")]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// Determines when and how all tools from this MCP server execute: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_mode")]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// List of per-tool configuration overrides that override the server-level defaults for specific tools
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_config_overrides")]
        public global::System.Collections.Generic.IList<global::G.MCPToolConfigOverride>? ToolConfigOverrides { get; set; }

        /// <summary>
        /// Whether to disable HTTP compression for this MCP server. Enable this if the server does not support compressed responses.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_compression")]
        public bool? DisableCompression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigOutput" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.<br/>
        /// Default Value: require_approval_all
        /// </param>
        /// <param name="toolApprovalHashes">
        /// List of tool approval hashes for per-tool approval when approval_policy is REQUIRE_APPROVAL_PER_TOOL
        /// </param>
        /// <param name="transport">
        /// The transport type used to connect to the MCP server<br/>
        /// Default Value: SSE
        /// </param>
        /// <param name="url">
        /// The URL of the MCP server, if this contains a secret please store as a workspace secret, otherwise store as a plain string. Must use https
        /// </param>
        /// <param name="secretToken">
        /// The secret token (Authorization header) stored as a workspace secret or in-place secret
        /// </param>
        /// <param name="requestHeaders">
        /// The headers included in the request
        /// </param>
        /// <param name="authConnection">
        /// Optional auth connection to use for authentication with this MCP server
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="forcePreToolSpeech">
        /// If true, all tools from this MCP server will require pre-tool execution speech<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableInterruptions">
        /// If true, the user will not be able to interrupt the agent while any tool from this MCP server is running.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play for all tools from this MCP server<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="executionMode">
        /// Determines when and how all tools from this MCP server execute: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </param>
        /// <param name="toolConfigOverrides">
        /// List of per-tool configuration overrides that override the server-level defaults for specific tools
        /// </param>
        /// <param name="disableCompression">
        /// Whether to disable HTTP compression for this MCP server. Enable this if the server does not support compressed responses.<br/>
        /// Default Value: false
        /// </param>
        public MCPServerConfigOutput(
            global::G.AnyOf<string, global::G.ConvAISecretLocator> url,
            string name,
            global::G.MCPApprovalPolicy? approvalPolicy,
            global::System.Collections.Generic.IList<global::G.MCPToolApprovalHash>? toolApprovalHashes,
            global::G.MCPServerTransport? transport,
            global::G.AnyOf<global::G.ConvAISecretLocator, global::G.ConvAIUserSecretDBModel, object>? secretToken,
            object? requestHeaders,
            global::G.AuthConnectionLocator? authConnection,
            string? description,
            bool? forcePreToolSpeech,
            bool? disableInterruptions,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::G.ToolExecutionMode? executionMode,
            global::System.Collections.Generic.IList<global::G.MCPToolConfigOverride>? toolConfigOverrides,
            bool? disableCompression)
        {
            this.Url = url;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApprovalPolicy = approvalPolicy;
            this.ToolApprovalHashes = toolApprovalHashes;
            this.Transport = transport;
            this.SecretToken = secretToken;
            this.RequestHeaders = requestHeaders;
            this.AuthConnection = authConnection;
            this.Description = description;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.DisableInterruptions = disableInterruptions;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ExecutionMode = executionMode;
            this.ToolConfigOverrides = toolConfigOverrides;
            this.DisableCompression = disableCompression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerConfigOutput" /> class.
        /// </summary>
        public MCPServerConfigOutput()
        {
        }
    }
}