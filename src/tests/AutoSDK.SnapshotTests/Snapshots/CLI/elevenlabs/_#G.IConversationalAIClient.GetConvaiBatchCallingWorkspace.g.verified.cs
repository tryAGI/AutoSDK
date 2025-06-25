//HintName: G.IConversationalAIClient.GetConvaiBatchCallingWorkspace.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get All Batch Calls For A Workspace.<br/>
        /// Get all batch calls for the current workspace.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="lastDoc"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WorkspaceBatchCallsResponse> GetConvaiBatchCallingWorkspaceAsync(
            int? limit = default,
            string? lastDoc = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}