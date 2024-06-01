//HintName: G.ReposClient.ReposCreateCommitStatus.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a commit status
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Status> ReposCreateCommitStatusAsync(
            string owner,
            string repo,
            string sha,
            ReposCreateCommitStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/statuses/{sha}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Status?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a commit status
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="state"></param>
        /// <param name="targetUrl"></param>
        /// <param name="description"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Status> ReposCreateCommitStatusAsync(
            string owner,
            string repo,
            string sha,
            ReposCreateCommitStatusRequestState state,
            string? targetUrl = default,
            string? description = default,
            string? context = "default",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateCommitStatusRequest
            {
                State = state,
                TargetUrl = targetUrl,
                Description = description,
                Context = context,
            };

            return await ReposCreateCommitStatusAsync(
                owner: owner,
                repo: repo,
                sha: sha,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}