//HintName: G.IAgentsPlatformClient.EditConvaiToolsByToolId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Update Tool<br/>
        /// Update tool that is available in the workspace.
        /// </summary>
        /// <param name="toolId">
        /// ID of the requested tool.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolResponseModel> EditConvaiToolsByToolIdAsync(
            string toolId,

            global::G.ToolRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tool<br/>
        /// Update tool that is available in the workspace.
        /// </summary>
        /// <param name="toolId">
        /// ID of the requested tool.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="toolConfig">
        /// Configuration for the tool
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolResponseModel> EditConvaiToolsByToolIdAsync(
            string toolId,
            global::G.ToolConfig toolConfig,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}