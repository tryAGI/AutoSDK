//HintName: G.IChecksClient.ChecksListForSuite.g.cs
#nullable enable

namespace G
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// List check runs in a check suite<br/>
        /// Lists check runs for a check suite using its `id`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="checkName"></param>
        /// <param name="status"></param>
        /// <param name="filter">
        /// Default Value: latest
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChecksListForSuiteResponse> ChecksListForSuiteAsync(
            string owner,
            string repo,
            int checkSuiteId,
            string? checkName = default,
            global::G.ChecksListForSuiteStatus? status = default,
            global::G.ChecksListForSuiteFilter? filter = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}