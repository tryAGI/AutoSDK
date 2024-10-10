//HintName: G.ProjectsClient.ConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPost.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string chapterId,
            ref string? xiApiKey);
        partial void PrepareConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string chapterId,
            string? xiApiKey);
        partial void ProcessConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Convert Chapter<br/>
        /// Starts conversion of a specific chapter.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="chapterId">
        /// The chapter_id of the chapter. You can query GET https://api.elevenlabs.io/v1/projects/{project_id}/chapters to list all available chapters for a project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostResponse> ConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostAsync(
            string projectId,
            string chapterId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                chapterId: ref chapterId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/chapters/{chapterId}/convert",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                chapterId: chapterId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ConvertChapterV1ProjectsProjectIdChaptersChapterIdConvertPostResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}