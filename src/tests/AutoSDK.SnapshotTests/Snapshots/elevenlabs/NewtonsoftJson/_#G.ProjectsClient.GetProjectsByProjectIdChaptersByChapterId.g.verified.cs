﻿//HintName: G.ProjectsClient.GetProjectsByProjectIdChaptersByChapterId.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareGetProjectsByProjectIdChaptersByChapterIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string chapterId,
            ref string? xiApiKey);
        partial void PrepareGetProjectsByProjectIdChaptersByChapterIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string chapterId,
            string? xiApiKey);
        partial void ProcessGetProjectsByProjectIdChaptersByChapterIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetProjectsByProjectIdChaptersByChapterIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Chapter By Id<br/>
        /// Returns information about a specific chapter.
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
        public async global::System.Threading.Tasks.Task<global::G.ChapterResponseModel> GetProjectsByProjectIdChaptersByChapterIdAsync(
            string projectId,
            string chapterId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetProjectsByProjectIdChaptersByChapterIdArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                chapterId: ref chapterId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/chapters/{chapterId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetProjectsByProjectIdChaptersByChapterIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                chapterId: chapterId,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetProjectsByProjectIdChaptersByChapterIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetProjectsByProjectIdChaptersByChapterIdResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.ChapterResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}