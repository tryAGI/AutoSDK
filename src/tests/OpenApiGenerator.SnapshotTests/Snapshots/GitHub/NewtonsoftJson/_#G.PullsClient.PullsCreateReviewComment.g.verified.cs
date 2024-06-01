//HintName: G.PullsClient.PullsCreateReviewComment.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        /// <summary>
        /// Create a review comment for a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequestReviewComment> PullsCreateReviewCommentAsync(
            string owner,
            string repo,
            int pullNumber,
            PullsCreateReviewCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/{pullNumber}/comments", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<PullRequestReviewComment?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a review comment for a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="body"></param>
        /// <param name="commitId"></param>
        /// <param name="path"></param>
        /// <param name="position"></param>
        /// <param name="side"></param>
        /// <param name="line"></param>
        /// <param name="startLine"></param>
        /// <param name="startSide"></param>
        /// <param name="inReplyTo"></param>
        /// <param name="subjectType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequestReviewComment> PullsCreateReviewCommentAsync(
            string owner,
            string repo,
            int pullNumber,
            string body,
            string commitId,
            string path,
            int position = default,
            PullsCreateReviewCommentRequestSide? side = default,
            int line = default,
            int startLine = default,
            PullsCreateReviewCommentRequestStartSide? startSide = default,
            int inReplyTo = default,
            PullsCreateReviewCommentRequestSubjectType? subjectType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new PullsCreateReviewCommentRequest
            {
                Body = body,
                CommitId = commitId,
                Path = path,
                Position = position,
                Side = side,
                Line = line,
                StartLine = startLine,
                StartSide = startSide,
                InReplyTo = inReplyTo,
                SubjectType = subjectType,
            };

            return await PullsCreateReviewCommentAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}