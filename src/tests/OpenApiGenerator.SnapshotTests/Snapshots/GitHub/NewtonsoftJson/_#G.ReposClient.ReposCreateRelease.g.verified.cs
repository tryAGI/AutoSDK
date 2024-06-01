//HintName: G.ReposClient.ReposCreateRelease.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a release
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Release> ReposCreateReleaseAsync(
            string owner,
            string repo,
            ReposCreateReleaseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/releases", global::System.UriKind.RelativeOrAbsolute));
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
        /// Create a release
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="targetCommitish"></param>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="draft"></param>
        /// <param name="prerelease"></param>
        /// <param name="discussionCategoryName"></param>
        /// <param name="generateReleaseNotes"></param>
        /// <param name="makeLatest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Release> ReposCreateReleaseAsync(
            string owner,
            string repo,
            string tagName,
            string? targetCommitish = default,
            string? name = default,
            string? body = default,
            bool draft = false,
            bool prerelease = false,
            string? discussionCategoryName = default,
            bool generateReleaseNotes = false,
            ReposCreateReleaseRequestMakeLatest? makeLatest = ReposCreateReleaseRequestMakeLatest.True,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateReleaseRequest
            {
                TagName = tagName,
                TargetCommitish = targetCommitish,
                Name = name,
                Body = body,
                Draft = draft,
                Prerelease = prerelease,
                DiscussionCategoryName = discussionCategoryName,
                GenerateReleaseNotes = generateReleaseNotes,
                MakeLatest = makeLatest,
            };

            return await ReposCreateReleaseAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}