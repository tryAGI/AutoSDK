//HintName: G.ChecksClient.ChecksUpdate.g.cs

#nullable enable

namespace G
{
    public partial class ChecksClient
    {
        partial void PrepareChecksUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int checkRunId,
            global::G.ChecksUpdateRequest request);
        partial void PrepareChecksUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int checkRunId,
            global::G.ChecksUpdateRequest request);
        partial void ProcessChecksUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChecksUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a check run<br/>
        /// Updates a check run for a specific commit in a repository.<br/>
        /// **Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CheckRun> ChecksUpdateAsync(
            string owner,
            string repo,
            int checkRunId,
            global::G.ChecksUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareChecksUpdateArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                checkRunId: ref checkRunId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/check-runs/{checkRunId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChecksUpdateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                checkRunId: checkRunId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessChecksUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChecksUpdateResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckRun?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a check run<br/>
        /// Updates a check run for a specific commit in a repository.<br/>
        /// **Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkRunId"></param>
        /// <param name="name">
        /// The name of the check. For example, "code-coverage".
        /// </param>
        /// <param name="detailsUrl">
        /// The URL of the integrator's site that has the full details of the check.
        /// </param>
        /// <param name="externalId">
        /// A reference for the run on the integrator's system.
        /// </param>
        /// <param name="startedAt">
        /// This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="status">
        /// The current status of the check run. Only GitHub Actions can set a status of `waiting`, `pending`, or `requested`.
        /// </param>
        /// <param name="conclusion">
        /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check. <br/>
        /// **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
        /// </param>
        /// <param name="completedAt">
        /// The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="output">
        /// Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run.
        /// </param>
        /// <param name="actions">
        /// Possible further actions the integrator can perform, which a user may trigger. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. To learn more about check runs and requested actions, see "[Check runs and requested actions](https://docs.github.com/rest/guides/using-the-rest-api-to-interact-with-checks#check-runs-and-requested-actions)."
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CheckRun> ChecksUpdateAsync(
            string owner,
            string repo,
            int checkRunId,
            string? name = default,
            string? detailsUrl = default,
            string? externalId = default,
            global::System.DateTime startedAt = default,
            global::G.ChecksUpdateRequestStatus? status = default,
            global::G.ChecksUpdateRequestConclusion? conclusion = default,
            global::System.DateTime completedAt = default,
            global::G.ChecksUpdateRequestOutput? output = default,
            global::System.Collections.Generic.IList<global::G.ChecksUpdateRequestAction>? actions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ChecksUpdateRequest
            {
                Name = name,
                DetailsUrl = detailsUrl,
                ExternalId = externalId,
                StartedAt = startedAt,
                Status = status,
                Conclusion = conclusion,
                CompletedAt = completedAt,
                Output = output,
                Actions = actions,
            };

            return await ChecksUpdateAsync(
                owner: owner,
                repo: repo,
                checkRunId: checkRunId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}