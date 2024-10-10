//HintName: G.ProjectsClient.EditBasicProjectInfoV1ProjectsProjectIdPost.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareEditBasicProjectInfoV1ProjectsProjectIdPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string? xiApiKey,
            global::G.BodyEditBasicProjectInfoV1ProjectsProjectIdPost request);
        partial void PrepareEditBasicProjectInfoV1ProjectsProjectIdPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string? xiApiKey,
            global::G.BodyEditBasicProjectInfoV1ProjectsProjectIdPost request);
        partial void ProcessEditBasicProjectInfoV1ProjectsProjectIdPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditBasicProjectInfoV1ProjectsProjectIdPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Edit Basic Project Info<br/>
        /// Edits basic project info.
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
        public async global::System.Threading.Tasks.Task<global::G.EditProjectResponseModel> EditBasicProjectInfoV1ProjectsProjectIdPostAsync(
            string projectId,
            global::G.BodyEditBasicProjectInfoV1ProjectsProjectIdPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareEditBasicProjectInfoV1ProjectsProjectIdPostArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}",
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
            PrepareEditBasicProjectInfoV1ProjectsProjectIdPostRequest(
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
            ProcessEditBasicProjectInfoV1ProjectsProjectIdPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessEditBasicProjectInfoV1ProjectsProjectIdPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.EditProjectResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Edit Basic Project Info<br/>
        /// Edits basic project info.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name of the project, used for identification only.
        /// </param>
        /// <param name="defaultTitleVoiceId">
        /// The voice_id that corresponds to the default voice used for new titles.
        /// </param>
        /// <param name="defaultParagraphVoiceId">
        /// The voice_id that corresponds to the default voice used for new paragraphs.
        /// </param>
        /// <param name="title">
        /// An optional name of the author of the project, this will be added as metadata to the mp3 file on project / chapter download.
        /// </param>
        /// <param name="author">
        /// An optional name of the author of the project, this will be added as metadata to the mp3 file on project / chapter download.
        /// </param>
        /// <param name="isbnNumber">
        /// An optional ISBN number of the project you want to create, this will be added as metadata to the mp3 file on project / chapter download.
        /// </param>
        /// <param name="volumeNormalization">
        /// When the project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EditProjectResponseModel> EditBasicProjectInfoV1ProjectsProjectIdPostAsync(
            string projectId,
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string? xiApiKey = default,
            string? title = default,
            string? author = default,
            string? isbnNumber = default,
            bool? volumeNormalization = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyEditBasicProjectInfoV1ProjectsProjectIdPost
            {
                Name = name,
                DefaultTitleVoiceId = defaultTitleVoiceId,
                DefaultParagraphVoiceId = defaultParagraphVoiceId,
                Title = title,
                Author = author,
                IsbnNumber = isbnNumber,
                VolumeNormalization = volumeNormalization,
            };

            return await EditBasicProjectInfoV1ProjectsProjectIdPostAsync(
                projectId: projectId,
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}