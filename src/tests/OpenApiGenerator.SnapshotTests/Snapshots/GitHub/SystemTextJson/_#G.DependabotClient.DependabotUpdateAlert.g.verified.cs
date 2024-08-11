//HintName: G.DependabotClient.DependabotUpdateAlert.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotUpdateAlertArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int alertNumber,
            global::G.DependabotUpdateAlertRequest request);
        partial void PrepareDependabotUpdateAlertRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int alertNumber,
            global::G.DependabotUpdateAlertRequest request);
        partial void ProcessDependabotUpdateAlertResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotUpdateAlertResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a Dependabot alert<br/>
        /// The authenticated user must have access to security alerts for the repository to use this endpoint. For more information, see "[Granting access to security alerts](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-security-and-analysis-settings-for-your-repository#granting-access-to-security-alerts)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DependabotAlert> DependabotUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::G.DependabotUpdateAlertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDependabotUpdateAlertArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                alertNumber: ref alertNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/dependabot/alerts/{alertNumber}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotUpdateAlertRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotUpdateAlertResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependabotUpdateAlertResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependabotAlert?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a Dependabot alert<br/>
        /// The authenticated user must have access to security alerts for the repository to use this endpoint. For more information, see "[Granting access to security alerts](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-security-and-analysis-settings-for-your-repository#granting-access-to-security-alerts)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.
        /// </param>
        /// <param name="state">
        /// The state of the Dependabot alert.<br/>
        /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when `state` is `dismissed`.** A reason for dismissing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// An optional comment associated with dismissing the alert.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DependabotAlert> DependabotUpdateAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::G.DependabotUpdateAlertRequestState state,
            global::G.DependabotUpdateAlertRequestDismissedReason? dismissedReason = default,
            string? dismissedComment = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.DependabotUpdateAlertRequest
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