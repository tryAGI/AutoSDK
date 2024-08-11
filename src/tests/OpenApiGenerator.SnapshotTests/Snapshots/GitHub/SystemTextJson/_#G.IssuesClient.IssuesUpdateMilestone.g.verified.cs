//HintName: G.IssuesClient.IssuesUpdateMilestone.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesUpdateMilestoneArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int milestoneNumber,
            global::G.IssuesUpdateMilestoneRequest request);
        partial void PrepareIssuesUpdateMilestoneRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int milestoneNumber,
            global::G.IssuesUpdateMilestoneRequest request);
        partial void ProcessIssuesUpdateMilestoneResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesUpdateMilestoneResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a milestone
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Milestone> IssuesUpdateMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            global::G.IssuesUpdateMilestoneRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareIssuesUpdateMilestoneArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                milestoneNumber: ref milestoneNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/milestones/{milestoneNumber}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIssuesUpdateMilestoneRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIssuesUpdateMilestoneResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIssuesUpdateMilestoneResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Milestone?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a milestone
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="title">
        /// The title of the milestone.
        /// </param>
        /// <param name="state">
        /// The state of the milestone. Either `open` or `closed`.<br/>
        /// Default Value: open
        /// </param>
        /// <param name="description">
        /// A description of the milestone.
        /// </param>
        /// <param name="dueOn">
        /// The milestone due date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Milestone> IssuesUpdateMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            string? title = default,
            global::G.IssuesUpdateMilestoneRequestState? state = global::G.IssuesUpdateMilestoneRequestState.Open,
            string? description = default,
            global::System.DateTime dueOn = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.IssuesUpdateMilestoneRequest
            {
                Title = title,
                State = state,
                Description = description,
                DueOn = dueOn,
            };

            return await IssuesUpdateMilestoneAsync(
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}