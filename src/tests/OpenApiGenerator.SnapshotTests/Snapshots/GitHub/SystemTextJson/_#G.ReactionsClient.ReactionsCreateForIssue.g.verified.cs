//HintName: G.ReactionsClient.ReactionsCreateForIssue.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsCreateForIssueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int issueNumber,
            global::G.ReactionsCreateForIssueRequest request);
        partial void PrepareReactionsCreateForIssueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int issueNumber,
            global::G.ReactionsCreateForIssueRequest request);
        partial void ProcessReactionsCreateForIssueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsCreateForIssueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create reaction for an issue<br/>
        /// Create a reaction to an [issue](https://docs.github.com/rest/issues/issues#get-an-issue). A response with an HTTP `200` status means that you already added the reaction type to this issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.ReactionsCreateForIssueRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReactionsCreateForIssueArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                issueNumber: ref issueNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/issues/{issueNumber}/reactions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsCreateForIssueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReactionsCreateForIssueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsCreateForIssueResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Reaction?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create reaction for an issue<br/>
        /// Create a reaction to an [issue](https://docs.github.com/rest/issues/issues#get-an-issue). A response with an HTTP `200` status means that you already added the reaction type to this issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.ReactionsCreateForIssueRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReactionsCreateForIssueRequest
            {
                Content = content,
            };

            return await ReactionsCreateForIssueAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}