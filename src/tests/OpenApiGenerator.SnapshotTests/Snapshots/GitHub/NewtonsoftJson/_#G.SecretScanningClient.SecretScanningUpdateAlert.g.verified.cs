//HintName: G.SecretScanningClient.SecretScanningUpdateAlert.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        /// <summary>
        /// Update a secret scanning alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<SecretScanningAlert> SecretScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            SecretScanningUpdateAlertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/secret-scanning/alerts/{alertNumber}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<SecretScanningAlert?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a secret scanning alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="state"></param>
        /// <param name="resolution"></param>
        /// <param name="resolutionComment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<SecretScanningAlert> SecretScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            SecretScanningUpdateAlertRequestState state,
            SecretScanningUpdateAlertRequestResolution? resolution = default,
            string? resolutionComment = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SecretScanningUpdateAlertRequest
            {
                State = state,
                Resolution = resolution,
                ResolutionComment = resolutionComment,
            };

            return await SecretScanningUpdateAlertAsync(
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}