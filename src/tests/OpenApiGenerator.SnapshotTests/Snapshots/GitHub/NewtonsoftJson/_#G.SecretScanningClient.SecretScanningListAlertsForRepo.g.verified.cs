//HintName: G.SecretScanningClient.SecretScanningListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<SecretScanningAlert>> SecretScanningListAlertsForRepoAsync(
            string owner,
            string repo,
            SecretScanningListAlertsForRepoState state,
            string secretType,
            string resolution,
            SecretScanningListAlertsForRepoSort sort,
            SecretScanningListAlertsForRepoDirection direction,
            int page,
            int perPage,
            string before,
            string after,
            string validity,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var stateValue = state switch
            {
                SecretScanningListAlertsForRepoState.Open => "open",
                SecretScanningListAlertsForRepoState.Resolved => "resolved",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                SecretScanningListAlertsForRepoSort.Created => "created",
                SecretScanningListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                SecretScanningListAlertsForRepoDirection.Asc => "asc",
                SecretScanningListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/secret-scanning/alerts?state={stateValue}&secret_type={secretType}&resolution={resolution}&sort={sortValue}&direction={directionValue}&page={page}&per_page={perPage}&before={before}&after={after}&validity={validity}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<SecretScanningAlert>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}