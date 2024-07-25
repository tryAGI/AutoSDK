//HintName: G.CommentsClient.CreateSubComment.g.cs

#nullable enable

namespace G
{
    public partial class CommentsClient
    {
        partial void PrepareCreateSubCommentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string parentCommentId,
            global::G.CreateCommentRequest request);
        partial void PrepareCreateSubCommentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string parentCommentId,
            global::G.CreateCommentRequest request);
        partial void ProcessCreateSubCommentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSubCommentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Sub Comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Comment> CreateSubCommentAsync(
            string owner,
            string repo,
            string parentCommentId,
            global::G.CreateCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateSubCommentArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                parentCommentId: ref parentCommentId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/comments/{owner}/{repo}/{parentCommentId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateSubCommentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                parentCommentId: parentCommentId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateSubCommentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateSubCommentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Comment?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Sub Comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Comment> CreateSubCommentAsync(
            string owner,
            string repo,
            string parentCommentId,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateCommentRequest
            {
                Content = content,
            };

            return await CreateSubCommentAsync(
                owner: owner,
                repo: repo,
                parentCommentId: parentCommentId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}