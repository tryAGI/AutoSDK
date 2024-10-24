//HintName: G.ProjectsClient.CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStream.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string chapterId,
            ref string chapterSnapshotId,
            ref string? xiApiKey,
            global::G.BodyStreamChapterAudioV1ProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost request);
        partial void PrepareCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            string? xiApiKey,
            global::G.BodyStreamChapterAudioV1ProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost request);
        partial void ProcessCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the chapter snapshots of a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="chapterId">
        /// The chapter_id of the chapter. You can query GET https://api.elevenlabs.io/v1/projects/{project_id}/chapters to list all available chapters for a project.
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The chapter_snapshot_id of the chapter snapshot. You can query GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots to the all available snapshots for a chapter.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            global::G.BodyStreamChapterAudioV1ProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                chapterId: ref chapterId,
                chapterSnapshotId: ref chapterSnapshotId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/chapters/{chapterId}/snapshots/{chapterSnapshotId}/stream",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                chapterId: chapterId,
                chapterSnapshotId: chapterSnapshotId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamResponseContent(
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
                global::G.HTTPValidationError.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the chapter snapshots of a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="chapterId">
        /// The chapter_id of the chapter. You can query GET https://api.elevenlabs.io/v1/projects/{project_id}/chapters to list all available chapters for a project.
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The chapter_snapshot_id of the chapter snapshot. You can query GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots to the all available snapshots for a chapter.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="convertToMpeg">
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            string? xiApiKey = default,
            bool? convertToMpeg = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyStreamChapterAudioV1ProjectsProjectIdChaptersChapterIdSnapshotsChapterSnapshotIdStreamPost
            {
                ConvertToMpeg = convertToMpeg,
            };

            return await CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
                projectId: projectId,
                chapterId: chapterId,
                chapterSnapshotId: chapterSnapshotId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}