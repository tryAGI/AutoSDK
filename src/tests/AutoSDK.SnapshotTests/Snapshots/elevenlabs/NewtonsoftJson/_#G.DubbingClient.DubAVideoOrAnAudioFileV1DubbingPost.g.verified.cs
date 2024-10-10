//HintName: G.DubbingClient.DubAVideoOrAnAudioFileV1DubbingPost.g.cs

#nullable enable

namespace G
{
    public partial class DubbingClient
    {
        partial void PrepareDubAVideoOrAnAudioFileV1DubbingPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request);
        partial void PrepareDubAVideoOrAnAudioFileV1DubbingPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request);
        partial void ProcessDubAVideoOrAnAudioFileV1DubbingPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDubAVideoOrAnAudioFileV1DubbingPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Dub A Video Or An Audio File<br/>
        /// Dubs provided audio or video file into given language.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DoDubbingResponseModel> DubAVideoOrAnAudioFileV1DubbingPostAsync(
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDubAVideoOrAnAudioFileV1DubbingPostArguments(
                httpClient: _httpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/dubbing",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            if (request.File != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                    {
                        Headers =
                        {
                            ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                        },
                    },
                    name: "file",
                    fileName: request.Filename ?? string.Empty);
            } 
            if (request.Name != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Name}"),
                    name: "name");
            } 
            if (request.SourceUrl != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SourceUrl}"),
                    name: "source_url");
            } 
            if (request.SourceLang != "auto")
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SourceLang}"),
                    name: "source_lang");
            } 
            if (request.TargetLang != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetLang}"),
                    name: "target_lang");
            } 
            if (request.NumSpeakers != 0)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumSpeakers}"),
                    name: "num_speakers");
            } 
            if (request.Watermark != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Watermark}"),
                    name: "watermark");
            } 
            if (request.StartTime != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StartTime}"),
                    name: "start_time");
            } 
            if (request.EndTime != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EndTime}"),
                    name: "end_time");
            } 
            if (request.HighestResolution != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HighestResolution}"),
                    name: "highest_resolution");
            } 
            if (request.DropBackgroundAudio != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DropBackgroundAudio}"),
                    name: "drop_background_audio");
            } 
            if (request.UseProfanityFilter != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UseProfanityFilter}"),
                    name: "use_profanity_filter");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDubAVideoOrAnAudioFileV1DubbingPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDubAVideoOrAnAudioFileV1DubbingPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDubAVideoOrAnAudioFileV1DubbingPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DoDubbingResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Dub A Video Or An Audio File<br/>
        /// Dubs provided audio or video file into given language.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="file">
        /// A list of file paths to audio recordings intended for voice cloning
        /// </param>
        /// <param name="filename">
        /// A list of file paths to audio recordings intended for voice cloning
        /// </param>
        /// <param name="name">
        /// Name of the dubbing project.
        /// </param>
        /// <param name="sourceUrl">
        /// URL of the source video/audio file.
        /// </param>
        /// <param name="sourceLang">
        /// Source language.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="targetLang">
        /// The Target language to dub the content into.
        /// </param>
        /// <param name="numSpeakers">
        /// Number of speakers to use for the dubbing. Set to 0 to automatically detect the number of speakers<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="watermark">
        /// Whether to apply watermark to the output video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startTime">
        /// Start time of the source video/audio file.
        /// </param>
        /// <param name="endTime">
        /// End time of the source video/audio file.
        /// </param>
        /// <param name="highestResolution">
        /// Whether to use the highest resolution available.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dropBackgroundAudio">
        /// An advanced setting. Whether to drop background audio from the final dub. This can improve dub quality where it's known that audio shouldn't have a background track such as for speeches or monologues.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useProfanityFilter">
        /// [BETA] Whether transcripts should have profanities censored with the words '[censored]'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DoDubbingResponseModel> DubAVideoOrAnAudioFileV1DubbingPostAsync(
            string? xiApiKey = default,
            byte[]? file = default,
            string? filename = default,
            string? name = default,
            string? sourceUrl = default,
            string? sourceLang = "auto",
            string? targetLang = default,
            int? numSpeakers = 0,
            bool? watermark = false,
            int? startTime = default,
            int? endTime = default,
            bool? highestResolution = false,
            bool? dropBackgroundAudio = false,
            bool? useProfanityFilter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost
            {
                File = file,
                Filename = filename,
                Name = name,
                SourceUrl = sourceUrl,
                SourceLang = sourceLang,
                TargetLang = targetLang,
                NumSpeakers = numSpeakers,
                Watermark = watermark,
                StartTime = startTime,
                EndTime = endTime,
                HighestResolution = highestResolution,
                DropBackgroundAudio = dropBackgroundAudio,
                UseProfanityFilter = useProfanityFilter,
            };

            return await DubAVideoOrAnAudioFileV1DubbingPostAsync(
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}