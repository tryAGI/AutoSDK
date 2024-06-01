//HintName: G.ProjectsClient.ProjectsAddCollaborator.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        /// <summary>
        /// Add project collaborator
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> ProjectsAddCollaboratorAsync(
            int projectId,
            string username,
            ProjectsAddCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/projects/{projectId}/collaborators/{username}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<BasicError?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add project collaborator
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="permission"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> ProjectsAddCollaboratorAsync(
            int projectId,
            string username,
            ProjectsAddCollaboratorRequestPermission? permission = ProjectsAddCollaboratorRequestPermission.Write,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ProjectsAddCollaboratorRequest
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