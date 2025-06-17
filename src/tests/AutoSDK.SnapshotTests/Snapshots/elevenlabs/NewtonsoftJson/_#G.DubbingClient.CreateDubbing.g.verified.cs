//HintName: G.DubbingClient.CreateDubbing.g.cs

#nullable enable

namespace G
{
    public partial class DubbingClient
    {
        partial void PrepareCreateDubbingArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request);
        partial void PrepareCreateDubbingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request);
        partial void ProcessCreateDubbingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDubbingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Dub A Video Or An Audio File<br/>
        /// Dubs a provided audio or video file into given language.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DoDubbingResponseModel> CreateDubbingAsync(
            global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDubbingArguments(
                httpClient: HttpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/dubbing",
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
                    content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
                    name: "file",
                    fileName: request.Filename ?? string.Empty);
            } 
            if (request.CsvFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.CsvFile ?? global::System.Array.Empty<byte>()),
                    name: "csv_file",
                    fileName: request.CsvFilename ?? string.Empty);
            } 
            if (request.ForegroundAudioFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.ForegroundAudioFile ?? global::System.Array.Empty<byte>()),
                    name: "foreground_audio_file",
                    fileName: request.ForegroundAudioFilename ?? string.Empty);
            } 
            if (request.BackgroundAudioFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.BackgroundAudioFile ?? global::System.Array.Empty<byte>()),
                    name: "background_audio_file",
                    fileName: request.BackgroundAudioFilename ?? string.Empty);
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
            if (request.SourceLang != default)
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
            if (request.NumSpeakers != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumSpeakers}"),
                    name: "num_speakers");
            } 
            if (request.Watermark != default)
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
            if (request.HighestResolution != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HighestResolution}"),
                    name: "highest_resolution");
            } 
            if (request.DropBackgroundAudio != default)
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
            if (request.DubbingStudio != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DubbingStudio}"),
                    name: "dubbing_studio");
            } 
            if (request.DisableVoiceCloning != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DisableVoiceCloning}"),
                    name: "disable_voice_cloning");
            } 
            if (request.Mode != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Mode}"),
                    name: "mode");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDubbingRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDubbingResponse(
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
                ProcessCreateDubbingResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DoDubbingResponseModel.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::G.DoDubbingResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Dub A Video Or An Audio File<br/>
        /// Dubs a provided audio or video file into given language.
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
        /// <param name="csvFile">
        /// CSV file containing transcription/translation metadata
        /// </param>
        /// <param name="csvFilename">
        /// CSV file containing transcription/translation metadata
        /// </param>
        /// <param name="foregroundAudioFile">
        /// For use only with csv input
        /// </param>
        /// <param name="foregroundAudioFilename">
        /// For use only with csv input
        /// </param>
        /// <param name="backgroundAudioFile">
        /// For use only with csv input
        /// </param>
        /// <param name="backgroundAudioFilename">
        /// For use only with csv input
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
        /// <param name="dubbingStudio">
        /// Whether to prepare dub for edits in dubbing studio or edits as a dubbing resource.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableVoiceCloning">
        /// [BETA] Instead of using a voice clone in dubbing, use a similar voice from the ElevenLabs Voice Library.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mode">
        /// automatic or manual. Manual mode is only supported when creating a dubbing studio project<br/>
        /// Default Value: automatic
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DoDubbingResponseModel> CreateDubbingAsync(
            string? xiApiKey = default,
            byte[]? file = default,
            string? filename = default,
            byte[]? csvFile = default,
            string? csvFilename = default,
            byte[]? foregroundAudioFile = default,
            string? foregroundAudioFilename = default,
            byte[]? backgroundAudioFile = default,
            string? backgroundAudioFilename = default,
            string? name = default,
            string? sourceUrl = default,
            string? sourceLang = default,
            string? targetLang = default,
            int? numSpeakers = default,
            bool? watermark = default,
            int? startTime = default,
            int? endTime = default,
            bool? highestResolution = default,
            bool? dropBackgroundAudio = default,
            bool? useProfanityFilter = default,
            bool? dubbingStudio = default,
            bool? disableVoiceCloning = default,
            string? mode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyDubAVideoOrAnAudioFileV1DubbingPost
            {
                File = file,
                Filename = filename,
                CsvFile = csvFile,
                CsvFilename = csvFilename,
                ForegroundAudioFile = foregroundAudioFile,
                ForegroundAudioFilename = foregroundAudioFilename,
                BackgroundAudioFile = backgroundAudioFile,
                BackgroundAudioFilename = backgroundAudioFilename,
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
                DubbingStudio = dubbingStudio,
                DisableVoiceCloning = disableVoiceCloning,
                Mode = mode,
            };

            return await CreateDubbingAsync(
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}