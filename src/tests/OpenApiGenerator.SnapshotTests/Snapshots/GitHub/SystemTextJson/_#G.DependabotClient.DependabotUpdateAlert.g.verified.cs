//HintName: G.DependabotClient.DependabotUpdateAlert.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        /// <summary>
        /// Update a Dependabot alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DependabotAlert> DependabotUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            DependabotUpdateAlertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/dependabot/alerts/{alertNumber}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<DependabotAlert?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a Dependabot alert
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber"></param>
        /// <param name="state"></param>
        /// <param name="dismissedReason"></param>
        /// <param name="dismissedComment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DependabotAlert> DependabotUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            DependabotUpdateAlertRequestState state,
            DependabotUpdateAlertRequestDismissedReason? dismissedReason = default,
            string? dismissedComment = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new DependabotUpdateAlertRequest
            {
                State = state,
                DismissedReason = dismissedReason,
                DismissedComment = dismissedComment,
            };

            return await DependabotUpdateAlertAsync(
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}