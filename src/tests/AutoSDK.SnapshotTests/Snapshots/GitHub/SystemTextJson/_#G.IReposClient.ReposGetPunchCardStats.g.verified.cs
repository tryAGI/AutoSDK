//HintName: G.IReposClient.ReposGetPunchCardStats.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get the hourly commit count for each day<br/>
        /// Each array contains the day number, hour number, and number of commits:<br/>
        /// *   `0-6`: Sunday - Saturday<br/>
        /// *   `0-23`: Hour of day<br/>
        /// *   Number of commits<br/>
        /// For example, `[2, 14, 25]` indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>> ReposGetPunchCardStatsAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}