//HintName: G.ProjectsClient.DeleteProjectServiceAccount.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareDeleteProjectServiceAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string serviceAccountId);
        partial void PrepareDeleteProjectServiceAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string serviceAccountId);
        partial void ProcessDeleteProjectServiceAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteProjectServiceAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Deletes a service account from the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectServiceAccountDeleteResponse> DeleteProjectServiceAccountAsync(
            string projectId,
            string serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteProjectServiceAccountArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                serviceAccountId: ref serviceAccountId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/organization/projects/{projectId}/service_accounts/{serviceAccountId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteProjectServiceAccountRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                serviceAccountId: serviceAccountId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteProjectServiceAccountResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteProjectServiceAccountResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::G.ProjectServiceAccountDeleteResponse), JsonSerializerContext) as global::G.ProjectServiceAccountDeleteResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}