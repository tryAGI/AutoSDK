//HintName: G.ReposClient.ReposUpdateRelease.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a release
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Release> ReposUpdateReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            ReposUpdateReleaseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/releases/{releaseId}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Release?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a release
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="tagName"></param>
        /// <param name="targetCommitish"></param>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="draft"></param>
        /// <param name="prerelease"></param>
        /// <param name="makeLatest"></param>
        /// <param name="discussionCategoryName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Release> ReposUpdateReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            string? tagName = default,
            string? targetCommitish = default,
            string? name = default,
            string? body = default,
            bool draft = default,
            bool prerelease = default,
            ReposUpdateReleaseRequestMakeLatest? makeLatest = ReposUpdateReleaseRequestMakeLatest.True,
            string? discussionCategoryName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateReleaseRequest
            {
                TagName = tagName,
                TargetCommitish = targetCommitish,
                Name = name,
                Body = body,
                Draft = draft,
                Prerelease = prerelease,
                MakeLatest = makeLatest,
                DiscussionCategoryName = discussionCategoryName,
            };

            return await ReposUpdateReleaseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}