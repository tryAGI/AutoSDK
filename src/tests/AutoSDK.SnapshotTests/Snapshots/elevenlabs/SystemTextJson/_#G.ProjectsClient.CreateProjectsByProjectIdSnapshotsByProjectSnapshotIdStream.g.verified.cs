//HintName: G.ProjectsClient.CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStream.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareCreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string projectSnapshotId,
            ref string? xiApiKey,
            global::G.BodyStreamProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost request);
        partial void PrepareCreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string projectSnapshotId,
            string? xiApiKey,
            global::G.BodyStreamProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost request);
        partial void ProcessCreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Stream Project Audio<br/>
        /// Stream the audio from a project snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The project_snapshot_id of the project snapshot. You can query GET /v1/projects/{project_id}/snapshots to list all available snapshots for a project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamAsync(
            string projectId,
            string projectSnapshotId,
            global::G.BodyStreamProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                projectSnapshotId: ref projectSnapshotId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/snapshots/{projectSnapshotId}/stream",
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
            PrepareCreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

        /// <summary>
        /// Stream Project Audio<br/>
        /// Stream the audio from a project snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The project_snapshot_id of the project snapshot. You can query GET /v1/projects/{project_id}/snapshots to list all available snapshots for a project.
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
        public async global::System.Threading.Tasks.Task CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamAsync(
            string projectId,
            string projectSnapshotId,
            string? xiApiKey = default,
            bool? convertToMpeg = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyStreamProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost
            {
                ConvertToMpeg = convertToMpeg,
            };

            await CreateProjectsByProjectIdSnapshotsByProjectSnapshotIdStreamAsync(
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}