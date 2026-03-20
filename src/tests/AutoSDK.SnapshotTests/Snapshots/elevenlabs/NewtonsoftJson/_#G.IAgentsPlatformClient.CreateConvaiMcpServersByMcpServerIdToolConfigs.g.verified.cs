//HintName: G.IAgentsPlatformClient.CreateConvaiMcpServersByMcpServerIdToolConfigs.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Create Mcp Tool Configuration Override<br/>
        /// Create configuration overrides for a specific MCP tool.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> CreateConvaiMcpServersByMcpServerIdToolConfigsAsync(
            string mcpServerId,

            global::G.MCPToolConfigOverrideCreateRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Mcp Tool Configuration Override<br/>
        /// Create configuration overrides for a specific MCP tool.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="forcePreToolSpeech">
        /// If set, overrides the server's force_pre_tool_speech setting for this tool
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// If set, overrides the server's tool_call_sound setting for this tool
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// If set, overrides the server's tool_call_sound_behavior setting for this tool
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="assignments">
        /// Dynamic variable assignments for this MCP tool
        /// </param>
        /// <param name="inputOverrides">
        /// Mapping of json path to input override configuration
        /// </param>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> CreateConvaiMcpServersByMcpServerIdToolConfigsAsync(
            string mcpServerId,
            string toolName,
            string? xiApiKey = default,
            bool? forcePreToolSpeech = default,
            bool? disableInterruptions = default,
            global::G.ToolCallSoundType? toolCallSound = default,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior = default,
            global::G.ToolExecutionMode? executionMode = default,
            global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? assignments = default,
            object? inputOverrides = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}