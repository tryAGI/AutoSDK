//HintName: G.ProjectsClient.ProjectsAddCollaborator.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsAddCollaboratorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int projectId,
            ref string username,
            global::G.ProjectsAddCollaboratorRequest request);
        partial void PrepareProjectsAddCollaboratorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int projectId,
            string username,
            global::G.ProjectsAddCollaboratorRequest request);
        partial void ProcessProjectsAddCollaboratorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsAddCollaboratorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add project collaborator<br/>
        /// Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project `admin` to add a collaborator.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> ProjectsAddCollaboratorAsync(
            int projectId,
            string username,
            global::G.ProjectsAddCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareProjectsAddCollaboratorArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                username: ref username,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/projects/{projectId}/collaborators/{username}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectsAddCollaboratorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                username: username,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectsAddCollaboratorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectsAddCollaboratorResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BasicError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add project collaborator<br/>
        /// Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project `admin` to add a collaborator.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="permission">
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> ProjectsAddCollaboratorAsync(
            int projectId,
            string username,
            global::G.ProjectsAddCollaboratorRequestPermission? permission = global::G.ProjectsAddCollaboratorRequestPermission.Write,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ProjectsAddCollaboratorRequest
            {
                Permission = permission,
            };

            return await ProjectsAddCollaboratorAsync(
                projectId: projectId,
                username: username,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}