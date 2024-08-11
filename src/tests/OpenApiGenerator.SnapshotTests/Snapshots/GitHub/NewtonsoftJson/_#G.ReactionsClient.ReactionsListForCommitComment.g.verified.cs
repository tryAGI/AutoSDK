//HintName: G.ReactionsClient.ReactionsListForCommitComment.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsListForCommitCommentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int commentId,
            ref global::G.ReactionsListForCommitCommentContent? content,
            ref int perPage,
            ref int page);
        partial void PrepareReactionsListForCommitCommentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int commentId,
            global::G.ReactionsListForCommitCommentContent? content,
            int perPage,
            int page);
        partial void ProcessReactionsListForCommitCommentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsListForCommitCommentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List reactions for a commit comment<br/>
        /// List the reactions to a [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment).
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Reaction>> ReactionsListForCommitCommentAsync(
            string owner,
            string repo,
            int commentId,
            global::G.ReactionsListForCommitCommentContent? content,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReactionsListForCommitCommentArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                commentId: ref commentId,
                content: ref content,
                perPage: ref perPage,
                page: ref page);

            var contentValue = content switch
            {
                global::G.ReactionsListForCommitCommentContent.Plus1 => "+1",
                global::G.ReactionsListForCommitCommentContent.Minus1 => "-1",
                global::G.ReactionsListForCommitCommentContent.Laugh => "laugh",
                global::G.ReactionsListForCommitCommentContent.Confused => "confused",
                global::G.ReactionsListForCommitCommentContent.Heart => "heart",
                global::G.ReactionsListForCommitCommentContent.Hooray => "hooray",
                global::G.ReactionsListForCommitCommentContent.Rocket => "rocket",
                global::G.ReactionsListForCommitCommentContent.Eyes => "eyes",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/comments/{commentId}/reactions?content={contentValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsListForCommitCommentRequest(
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
            ProcessReactionsListForCommitCommentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsListForCommitCommentResponseContent(
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