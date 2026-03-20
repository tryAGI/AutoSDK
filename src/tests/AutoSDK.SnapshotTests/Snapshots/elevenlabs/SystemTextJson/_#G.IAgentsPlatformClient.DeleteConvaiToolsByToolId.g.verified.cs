//HintName: G.IAgentsPlatformClient.DeleteConvaiToolsByToolId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Tool<br/>
        /// Delete tool from the workspace.
        /// </summary>
        /// <param name="toolId">
        /// ID of the requested tool.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConvaiToolsByToolIdAsync(
            string toolId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}