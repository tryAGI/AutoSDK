//HintName: G.ProjectsClient.ProjectsCreateColumn.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsCreateColumnArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int projectId,
            global::G.ProjectsCreateColumnRequest request);
        partial void PrepareProjectsCreateColumnRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int projectId,
            global::G.ProjectsCreateColumnRequest request);
        partial void ProcessProjectsCreateColumnResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsCreateColumnResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a project column<br/>
        /// Creates a new project column.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectColumn> ProjectsCreateColumnAsync(
            int projectId,
            global::G.ProjectsCreateColumnRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareProjectsCreateColumnArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/projects/{projectId}/columns", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectsCreateColumnRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectsCreateColumnResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectsCreateColumnResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProjectColumn?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a project column<br/>
        /// Creates a new project column.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectColumn> ProjectsCreateColumnAsync(
            int projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ProjectsCreateColumnRequest
            {
                Name = name,
            };

            return await ProjectsCreateColumnAsync(
                projectId: projectId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}