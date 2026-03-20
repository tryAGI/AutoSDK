//HintName: G.IAgentsPlatformClient.EditConvaiMcpServersByMcpServerId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Update Mcp Server Configuration<br/>
        /// Update the configuration settings for an MCP server.
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
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> EditConvaiMcpServersByMcpServerIdAsync(
            string mcpServerId,

            global::G.MCPServerConfigUpdateRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Mcp Server Configuration<br/>
        /// Update the configuration settings for an MCP server.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServerResponseModel> EditConvaiMcpServersByMcpServerIdAsync(
            string mcpServerId,
            string? xiApiKey = default,
            global::G.MCPApprovalPolicy? approvalPolicy = default,
            bool? forcePreToolSpeech = default,
            bool? disableInterruptions = default,
            global::G.ToolCallSoundType? toolCallSound = default,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior = default,
            global::G.ToolExecutionMode? executionMode = default,
            object? requestHeaders = default,
            bool? disableCompression = default,
            global::G.ConvAISecretLocator? secretToken = default,
            global::G.AuthConnectionLocator? authConnection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}