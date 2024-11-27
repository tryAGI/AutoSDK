//HintName: G.ReposClient.ReposDeleteRelease.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposDeleteReleaseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int releaseId);
        partial void PrepareReposDeleteReleaseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int releaseId);
        partial void ProcessReposDeleteReleaseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a release<br/>
        /// Users with push access to the repository can delete a release.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ReposDeleteReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposDeleteReleaseArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                releaseId: ref releaseId);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/releases/{releaseId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposDeleteReleaseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                releaseId: releaseId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposDeleteReleaseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}