//HintName: G.IReposClient.ReposGetContributorsStats.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all contributor commit activity<br/>
        /// Returns the `total` number of commits authored by the contributor. In addition, the response includes a Weekly Hash (`weeks` array) with the following information:<br/>
        /// *   `w` - Start of the week, given as a [Unix timestamp](https://en.wikipedia.org/wiki/Unix_time).<br/>
        /// *   `a` - Number of additions<br/>
        /// *   `d` - Number of deletions<br/>
        /// *   `c` - Number of commits<br/>
        /// **Note:** This endpoint will return `0` values for all addition and deletion counts in repositories with 10,000 or more commits.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ContributorActivity>> ReposGetContributorsStatsAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}