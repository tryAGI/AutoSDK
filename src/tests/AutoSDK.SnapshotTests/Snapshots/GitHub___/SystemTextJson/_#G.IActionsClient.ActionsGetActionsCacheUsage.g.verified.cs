//HintName: G.IActionsClient.ActionsGetActionsCacheUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub Actions cache usage for a repository<br/>
        /// Gets GitHub Actions cache usage for a repository.<br/>
        /// The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsCacheUsageByRepository> ActionsGetActionsCacheUsageAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}