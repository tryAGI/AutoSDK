//HintName: G.IReposClient.ReposGetCodeFrequencyStats.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get the weekly commit activity<br/>
        /// Returns a weekly aggregate of the number of additions and deletions pushed to a repository.<br/>
        /// **Note:** This endpoint can only be used for repositories with fewer than 10,000 commits. If the repository contains<br/>
        /// 10,000 or more commits, a 422 status code will be returned.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>> ReposGetCodeFrequencyStatsAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}