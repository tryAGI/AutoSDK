//HintName: G.IActionsClient.ActionsDeleteActionsCacheById.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete a GitHub Actions cache for a repository (using a cache ID)<br/>
        /// Deletes a GitHub Actions cache for a repository, using a cache ID.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cacheId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsDeleteActionsCacheByIdAsync(
            string owner,
            string repo,
            int cacheId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}