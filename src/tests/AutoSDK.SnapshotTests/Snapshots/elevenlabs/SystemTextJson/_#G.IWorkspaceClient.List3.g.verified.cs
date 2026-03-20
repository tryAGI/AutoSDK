//HintName: G.IWorkspaceClient.List3.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get All Groups<br/>
        /// Get all groups in the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::G.WorkspaceGroupResponseModel>> List3Async(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}