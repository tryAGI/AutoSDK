//HintName: G.ReactionsClient.ReactionsListForIssueComment.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsListForIssueCommentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int commentId,
            ref global::G.ReactionsListForIssueCommentContent? content,
            ref int perPage,
            ref int page);
        partial void PrepareReactionsListForIssueCommentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int commentId,
            global::G.ReactionsListForIssueCommentContent? content,
            int perPage,
            int page);
        partial void ProcessReactionsListForIssueCommentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsListForIssueCommentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List reactions for an issue comment<br/>
        /// List the reactions to an [issue comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="content"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Reaction>> ReactionsListForIssueCommentAsync(
            string owner,
            string repo,
            int commentId,
            global::G.ReactionsListForIssueCommentContent? content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReactionsListForIssueCommentArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                commentId: ref commentId,
                content: ref content,
                perPage: ref perPage,
                page: ref page);

            var contentValue = content switch
            {
                global::G.ReactionsListForIssueCommentContent.Plus1 => "+1",
                global::G.ReactionsListForIssueCommentContent.Minus1 => "-1",
                global::G.ReactionsListForIssueCommentContent.Laugh => "laugh",
                global::G.ReactionsListForIssueCommentContent.Confused => "confused",
                global::G.ReactionsListForIssueCommentContent.Heart => "heart",
                global::G.ReactionsListForIssueCommentContent.Hooray => "hooray",
                global::G.ReactionsListForIssueCommentContent.Rocket => "rocket",
                global::G.ReactionsListForIssueCommentContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/issues/comments/{commentId}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsListForIssueCommentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                commentId: commentId,
                content: content,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReactionsListForIssueCommentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsListForIssueCommentResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Reaction>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}