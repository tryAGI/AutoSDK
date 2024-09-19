//HintName: G.ProjectsClient.CreateProjectServiceAccount.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareCreateProjectServiceAccountArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            global::G.ProjectServiceAccountCreateRequest request);
        partial void PrepareCreateProjectServiceAccountRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            global::G.ProjectServiceAccountCreateRequest request);
        partial void ProcessCreateProjectServiceAccountResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateProjectServiceAccountResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a new service account in the project. This also returns an unredacted API key for the service account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectServiceAccountCreateResponse> CreateProjectServiceAccountAsync(
            string projectId,
            global::G.ProjectServiceAccountCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateProjectServiceAccountArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/organization/projects/{projectId}/service_accounts",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateProjectServiceAccountRequest(
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
            ProcessCreateProjectServiceAccountResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateProjectServiceAccountResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::G.ProjectServiceAccountCreateResponse), JsonSerializerContext) as global::G.ProjectServiceAccountCreateResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a new service account in the project. This also returns an unredacted API key for the service account.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// The name of the service account being created.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProjectServiceAccountCreateResponse> CreateProjectServiceAccountAsync(
            string projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ProjectServiceAccountCreateRequest
            {
                Name = name,
            };

            return await CreateProjectServiceAccountAsync(
                projectId: projectId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}