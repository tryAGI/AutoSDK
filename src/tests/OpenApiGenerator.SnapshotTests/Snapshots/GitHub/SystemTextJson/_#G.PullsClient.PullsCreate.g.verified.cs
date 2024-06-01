//HintName: G.PullsClient.PullsCreate.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        /// <summary>
        /// Create a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequest> PullsCreateAsync(
            string owner,
            string repo,
            PullsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<PullRequest?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="title"></param>
        /// <param name="head"></param>
        /// <param name="headRepo"></param>
        /// <param name="@base"></param>
        /// <param name="body"></param>
        /// <param name="maintainerCanModify"></param>
        /// <param name="draft"></param>
        /// <param name="issue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequest> PullsCreateAsync(
            string owner,
            string repo,
            string head,
            string @base,
            string? title = default,
            string? headRepo = default,
            string? body = default,
            bool maintainerCanModify = default,
            bool draft = default,
            long issue = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new PullsCreateRequest
            {
                Title = title,
                Head = head,
                HeadRepo = headRepo,
                Base = @base,
                Body = body,
                MaintainerCanModify = maintainerCanModify,
                Draft = draft,
                Issue = issue,
            };

            return await PullsCreateAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}