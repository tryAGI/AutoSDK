//HintName: G.CodeScanningClient.CodeScanningUpdateAlert.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        /// <summary>
        /// Update a code scanning alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodeScanningAlert> CodeScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            CodeScanningUpdateAlertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/code-scanning/alerts/{alertNumber}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<CodeScanningAlert?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a code scanning alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="state"></param>
        /// <param name="dismissedReason"></param>
        /// <param name="dismissedComment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodeScanningAlert> CodeScanningUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            CodeScanningUpdateAlertRequestState state,
            CodeScanningUpdateAlertRequestDismissedReason? dismissedReason = default,
            string? dismissedComment = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CodeScanningUpdateAlertRequest
            {
                State = state,
                DismissedReason = dismissedReason,
                DismissedComment = dismissedComment,
            };

            return await CodeScanningUpdateAlertAsync(
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}