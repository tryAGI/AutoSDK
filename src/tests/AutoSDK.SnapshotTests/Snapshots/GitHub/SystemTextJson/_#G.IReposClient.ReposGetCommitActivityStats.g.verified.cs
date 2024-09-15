//HintName: G.IReposClient.ReposGetCommitActivityStats.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get the last year of commit activity<br/>
        /// Returns the last year of commit activity grouped by week. The `days` array is a group of commits per day, starting on `Sunday`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CommitActivity>> ReposGetCommitActivityStatsAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}