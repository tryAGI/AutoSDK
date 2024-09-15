//HintName: G.IReposClient.ReposMergeUpstream.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Sync a fork branch with the upstream repository<br/>
        /// Sync a branch of a forked repository to keep it up-to-date with the upstream repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MergedUpstream> ReposMergeUpstreamAsync(
            string owner,
            string repo,
            global::G.ReposMergeUpstreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Sync a fork branch with the upstream repository<br/>
        /// Sync a branch of a forked repository to keep it up-to-date with the upstream repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch">
        /// The name of the branch which should be updated to match upstream.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MergedUpstream> ReposMergeUpstreamAsync(
            string owner,
            string repo,
            string branch,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}