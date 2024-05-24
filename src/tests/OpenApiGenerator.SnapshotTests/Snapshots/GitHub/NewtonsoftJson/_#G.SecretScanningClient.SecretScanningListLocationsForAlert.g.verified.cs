//HintName: G.SecretScanningClient.SecretScanningListLocationsForAlert.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        /// <summary>
        /// List locations for a secret scanning alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SecretScanningListLocationsForAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/secret-scanning/alerts/{alertNumber}/locations?page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}