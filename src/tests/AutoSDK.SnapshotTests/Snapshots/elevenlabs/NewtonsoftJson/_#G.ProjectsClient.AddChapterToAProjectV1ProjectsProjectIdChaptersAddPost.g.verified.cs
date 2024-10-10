//HintName: G.ProjectsClient.AddChapterToAProjectV1ProjectsProjectIdChaptersAddPost.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string? xiApiKey,
            global::G.BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost request);
        partial void PrepareAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string? xiApiKey,
            global::G.BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost request);
        partial void ProcessAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Chapter To A Project<br/>
        /// Creates a new chapter either as blank or from a URL.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddChapterResponseModel> AddChapterToAProjectV1ProjectsProjectIdChaptersAddPostAsync(
            string projectId,
            global::G.BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/chapters/add",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAddChapterToAProjectV1ProjectsProjectIdChaptersAddPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AddChapterResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add Chapter To A Project<br/>
        /// Creates a new chapter either as blank or from a URL.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name of the chapter, used for identification only.
        /// </param>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AddChapterResponseModel> AddChapterToAProjectV1ProjectsProjectIdChaptersAddPostAsync(
            string projectId,
            string name,
            string? xiApiKey = default,
            string? fromUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost
            {
                Name = name,
                FromUrl = fromUrl,
            };

            return await AddChapterToAProjectV1ProjectsProjectIdChaptersAddPostAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}