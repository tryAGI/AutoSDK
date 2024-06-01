//HintName: G.PullsClient.PullsRemoveRequestedReviewers.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        /// <summary>
        /// Remove requested reviewers from a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequestSimple> PullsRemoveRequestedReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            PullsRemoveRequestedReviewersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/{pullNumber}/requested_reviewers", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<PullRequestSimple?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Remove requested reviewers from a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="reviewers"></param>
        /// <param name="teamReviewers"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequestSimple> PullsRemoveRequestedReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            global::System.Collections.Generic.IList<string> reviewers,
            global::System.Collections.Generic.IList<string?>? teamReviewers = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new PullsRemoveRequestedReviewersRequest
            {
                Reviewers = reviewers,
                TeamReviewers = teamReviewers,
            };

            return await PullsRemoveRequestedReviewersAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}