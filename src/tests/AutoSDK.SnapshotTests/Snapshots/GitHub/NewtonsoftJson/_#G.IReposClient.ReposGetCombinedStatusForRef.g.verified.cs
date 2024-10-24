//HintName: G.IReposClient.ReposGetCombinedStatusForRef.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get the combined status for a specific reference<br/>
        /// Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.<br/>
        /// Additionally, a combined `state` is returned. The `state` is one of:<br/>
        /// *   **failure** if any of the contexts report as `error` or `failure`<br/>
        /// *   **pending** if there are no statuses or a context is `pending`<br/>
        /// *   **success** if the latest status for all contexts is `success`
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CombinedCommitStatus> ReposGetCombinedStatusForRefAsync(
            string owner,
            string repo,
            string @ref,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}