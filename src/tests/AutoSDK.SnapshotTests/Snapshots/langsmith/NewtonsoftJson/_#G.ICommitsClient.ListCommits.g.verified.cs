//HintName: G.ICommitsClient.ListCommits.g.cs
#nullable enable

namespace G
{
    public partial interface ICommitsClient
    {
        /// <summary>
        /// List Commits<br/>
        /// Get all commits.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCommitsResponse> ListCommitsAsync(
            string owner,
            string repo,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}