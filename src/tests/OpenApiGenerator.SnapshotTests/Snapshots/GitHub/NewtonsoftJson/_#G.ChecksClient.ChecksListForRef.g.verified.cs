//HintName: G.ChecksClient.ChecksListForRef.g.cs

#nullable enable

namespace G
{
    public partial class ChecksClient
    {
        /// <summary>
        /// List check runs for a Git reference
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="@ref"></param>
        /// <param name="checkName"></param>
        /// <param name="status"></param>
        /// <param name="filter"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ChecksListForRefResponse> ChecksListForRefAsync(
            string owner,
            string repo,
            string @ref,
            string checkName,
            ChecksListForRefStatus status,
            ChecksListForRefFilter filter,
            int perPage,
            int page,
            int appId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                ChecksListForRefStatus.Queued => "queued",
                ChecksListForRefStatus.InProgress => "in_progress",
                ChecksListForRefStatus.Completed => "completed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var filterValue = filter switch
            {
                ChecksListForRefFilter.Latest => "latest",
                ChecksListForRefFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/commits/{@ref}/check-runs?check_name={checkName}&status={statusValue}&filter={filterValue}&per_page={perPage}&page={page}&app_id={appId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ChecksListForRefResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}