//HintName: G.ProjectsClient.ProjectsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        /// <summary>
        /// Update a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Project> ProjectsUpdateAsync(
            int projectId,
            ProjectsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/projects/{projectId}", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<Project?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="state"></param>
        /// <param name="organizationPermission"></param>
        /// <param name="@private"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Project> ProjectsUpdateAsync(
            int projectId,
            string? name = default,
            string? body = default,
            string? state = default,
            ProjectsUpdateRequestOrganizationPermission? organizationPermission = default,
            bool @private = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ProjectsUpdateRequest
            {
                Name = name,
                Body = body,
                State = state,
                OrganizationPermission = organizationPermission,
                Private = @private,
            };

            return await ProjectsUpdateAsync(
                projectId: projectId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}