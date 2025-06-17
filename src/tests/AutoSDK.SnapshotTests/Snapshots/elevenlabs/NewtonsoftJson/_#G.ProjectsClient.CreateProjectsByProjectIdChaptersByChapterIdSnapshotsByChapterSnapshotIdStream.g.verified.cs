﻿//HintName: G.ProjectsClient.CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStream.g.cs

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

        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the chapter snapshots of a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The ID of the chapter snapshot.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
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

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/projects/{projectId}/chapters/{chapterId}/snapshots/{chapterSnapshotId}/stream",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Stream Chapter Audio<br/>
        /// Stream the audio from a chapter snapshot. Use `GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the chapter snapshots of a chapter.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="chapterSnapshotId">
        /// The ID of the chapter snapshot.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
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
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
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

            await CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
                projectId: projectId,
                chapterId: chapterId,
                chapterSnapshotId: chapterSnapshotId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}