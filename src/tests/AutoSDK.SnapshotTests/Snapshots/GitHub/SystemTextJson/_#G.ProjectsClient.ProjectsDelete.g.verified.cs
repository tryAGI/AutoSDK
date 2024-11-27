//HintName: G.ProjectsClient.ProjectsDelete.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int projectId);
        partial void PrepareProjectsDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int projectId);
        partial void ProcessProjectsDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a project<br/>
        /// Deletes a project board. Returns a `404 Not Found` status if projects are disabled.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ProjectsDeleteAsync(
            int projectId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareProjectsDeleteArguments(
                httpClient: HttpClient,
                projectId: ref projectId);

            var __pathBuilder = new PathBuilder(
                path: $"/projects/{projectId}",
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
            PrepareProjectsDeleteRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectsDeleteResponse(
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