//HintName: G.ReactionsClient.ReactionsCreateForRelease.g.cs

#nullable enable

namespace G
{
    public partial class ReactionsClient
    {
        partial void PrepareReactionsCreateForReleaseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int releaseId,
            global::G.ReactionsCreateForReleaseRequest request);
        partial void PrepareReactionsCreateForReleaseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int releaseId,
            global::G.ReactionsCreateForReleaseRequest request);
        partial void ProcessReactionsCreateForReleaseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReactionsCreateForReleaseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create reaction for a release<br/>
        /// Create a reaction to a [release](https://docs.github.com/rest/releases/releases#get-a-release). A response with a `Status: 200 OK` means that you already added the reaction type to this release.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            global::G.ReactionsCreateForReleaseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReactionsCreateForReleaseArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                releaseId: ref releaseId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/releases/{releaseId}/reactions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReactionsCreateForReleaseRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReactionsCreateForReleaseResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReactionsCreateForReleaseResponseContent(
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
        /// Create reaction for a release<br/>
        /// Create a reaction to a [release](https://docs.github.com/rest/releases/releases#get-a-release). A response with a `Status: 200 OK` means that you already added the reaction type to this release.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the release.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            global::G.ReactionsCreateForReleaseRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReactionsCreateForReleaseRequest
            {
                Content = content,
            };

            return await ReactionsCreateForReleaseAsync(
                owner: owner,
                repo: repo,
                releaseId: releaseId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}