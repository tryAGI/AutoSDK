//HintName: G.ProjectsClient.ProjectsRemoveCollaborator.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsRemoveCollaboratorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int projectId,
            ref string username);
        partial void PrepareProjectsRemoveCollaboratorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int projectId,
            string username);
        partial void ProcessProjectsRemoveCollaboratorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove user as a collaborator<br/>
        /// Removes a collaborator from an organization project. You must be an organization owner or a project `admin` to remove a collaborator.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ProjectsRemoveCollaboratorAsync(
            int projectId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareProjectsRemoveCollaboratorArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                username: ref username);

            var __pathBuilder = new PathBuilder(
                path: $"/projects/{projectId}/collaborators/{username}",
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
            PrepareProjectsRemoveCollaboratorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                username: username);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectsRemoveCollaboratorResponse(
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