//HintName: G.ChecksClient.ChecksListForSuite.g.cs

#nullable enable

namespace G
{
    public partial class ChecksClient
    {
        /// <summary>
        /// List check runs in a check suite
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="checkName"></param>
        /// <param name="status"></param>
        /// <param name="filter"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ChecksListForSuiteAsync(
            string owner,
            string repo,
            int checkSuiteId,
            string checkName,
            ChecksListForSuiteStatus status,
            ChecksListForSuiteFilter filter,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                ChecksListForSuiteStatus.Queued => "queued",
                ChecksListForSuiteStatus.InProgress => "in_progress",
                ChecksListForSuiteStatus.Completed => "completed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var filterValue = filter switch
            {
                ChecksListForSuiteFilter.Latest => "latest",
                ChecksListForSuiteFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/check-suites/{checkSuiteId}/check-runs?check_name={checkName}&status={statusValue}&filter={filterValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}