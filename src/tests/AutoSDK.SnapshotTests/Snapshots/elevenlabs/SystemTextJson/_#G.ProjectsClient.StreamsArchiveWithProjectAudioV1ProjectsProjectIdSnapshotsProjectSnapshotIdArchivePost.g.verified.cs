//HintName: G.ProjectsClient.StreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePost.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string projectSnapshotId,
            ref string? xiApiKey);
        partial void PrepareStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string projectSnapshotId,
            string? xiApiKey);
        partial void ProcessStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Streams Archive With Project Audio<br/>
        /// Streams archive with project audio.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> StreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostAsync(
            string projectId,
            string projectSnapshotId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                projectSnapshotId: ref projectSnapshotId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/snapshots/{projectSnapshotId}/archive",
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
            PrepareStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStreamsArchiveWithProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdArchivePostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.HTTPValidationError?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}