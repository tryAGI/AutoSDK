//HintName: G.IWorkspaceClient.GetWorkspaceGroupsSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Search User Groups<br/>
        /// Searches for user groups in the workspace. Multiple or no groups may be returned.
        /// </summary>
        /// <param name="name">
        /// Name of the target group.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.WorkspaceGroupByNameResponseModel>> GetWorkspaceGroupsSearchAsync(
            string name,
            string xiApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}