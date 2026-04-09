//HintName: G.TranscriptionV1Client.VideoToTextControllerVideoTranscription.g.cs

#nullable enable

namespace G
{
    public partial class TranscriptionV1Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_VideoToTextControllerVideoTranscriptionSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-gladia-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_VideoToTextControllerVideoTranscriptionSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_VideoToTextControllerVideoTranscriptionSecurityRequirement0,
            };
        partial void PrepareVideoToTextControllerVideoTranscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.VideoToTextControllerVideoTranscriptionRequest request);
        partial void PrepareVideoToTextControllerVideoTranscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.VideoToTextControllerVideoTranscriptionRequest request);
        partial void ProcessVideoToTextControllerVideoTranscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task VideoToTextControllerVideoTranscriptionAsync(

            global::G.VideoToTextControllerVideoTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareVideoToTextControllerVideoTranscriptionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_VideoToTextControllerVideoTranscriptionSecurityRequirements,
                operationName: "VideoToTextControllerVideoTranscriptionAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/video/text/video-transcription",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.Video != default)
            {

                var __contentVideo = new global::System.Net.Http.ByteArrayContent(request.Video ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentVideo,
                    name: "\"video\"",
                    fileName: request.Videoname != null ? $"\"{request.Videoname}\"" : string.Empty);
                if (__contentVideo.Headers.ContentDisposition != null)
                {
                    __contentVideo.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.VideoUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VideoUrl}"),
                    name: "\"video_url\"");
            } 
            if (request.LanguageBehaviour != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.LanguageBehaviour?.ToValueString()}"),
                    name: "\"language_behaviour\"");
            } 
            if (request.Language != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Language?.ToValueString()}"),
                    name: "\"language\"");
            } 
            if (request.TranscriptionHint != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TranscriptionHint}"),
                    name: "\"transcription_hint\"");
            } 
            if (request.ToggleDiarization != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ToggleDiarization}"),
                    name: "\"toggle_diarization\"");
            } 
            if (request.DiarizationNumSpeakers != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DiarizationNumSpeakers}"),
                    name: "\"diarization_num_speakers\"");
            } 
            if (request.DiarizationMinSpeakers != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DiarizationMinSpeakers}"),
                    name: "\"diarization_min_speakers\"");
            } 
            if (request.DiarizationMaxSpeakers != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DiarizationMaxSpeakers}"),
                    name: "\"diarization_max_speakers\"");
            } 
            if (request.ToggleDirectTranslate != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ToggleDirectTranslate}"),
                    name: "\"toggle_direct_translate\"");
            } 
            if (request.TargetTranslationLanguage != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetTranslationLanguage?.ToValueString()}"),
                    name: "\"target_translation_language\"");
            } 
            if (request.OutputFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormat?.ToValueString()}"),
                    name: "\"output_format\"");
            } 
            if (request.ToggleNoiseReduction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ToggleNoiseReduction}"),
                    name: "\"toggle_noise_reduction\"");
            } 
            if (request.ToggleAccurateWordsTimestamps != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ToggleAccurateWordsTimestamps}"),
                    name: "\"toggle_accurate_words_timestamps\"");
            } 
            if (request.WebhookUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.WebhookUrl}"),
                    name: "\"webhook_url\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareVideoToTextControllerVideoTranscriptionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessVideoToTextControllerVideoTranscriptionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="video"></param>
        /// <param name="videoname"></param>
        /// <param name="videoUrl">
        /// Default Value: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        /// <param name="languageBehaviour">
        /// Default Value: automatic single language
        /// </param>
        /// <param name="language"></param>
        /// <param name="transcriptionHint"></param>
        /// <param name="toggleDiarization">
        /// Default Value: false
        /// </param>
        /// <param name="diarizationNumSpeakers"></param>
        /// <param name="diarizationMinSpeakers"></param>
        /// <param name="diarizationMaxSpeakers"></param>
        /// <param name="toggleDirectTranslate">
        /// Default Value: false
        /// </param>
        /// <param name="targetTranslationLanguage"></param>
        /// <param name="outputFormat">
        /// Default Value: json
        /// </param>
        /// <param name="toggleNoiseReduction">
        /// Default Value: false
        /// </param>
        /// <param name="toggleAccurateWordsTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task VideoToTextControllerVideoTranscriptionAsync(
            byte[]? video = default,
            string? videoname = default,
            string? videoUrl = default,
            global::G.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviour? languageBehaviour = default,
            global::G.VideoToTextControllerVideoTranscriptionRequestLanguage? language = default,
            string? transcriptionHint = default,
            bool? toggleDiarization = default,
            int? diarizationNumSpeakers = default,
            int? diarizationMinSpeakers = default,
            int? diarizationMaxSpeakers = default,
            bool? toggleDirectTranslate = default,
            global::G.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguage? targetTranslationLanguage = default,
            global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat? outputFormat = default,
            bool? toggleNoiseReduction = default,
            bool? toggleAccurateWordsTimestamps = default,
            string? webhookUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.VideoToTextControllerVideoTranscriptionRequest
            {
                Video = video,
                Videoname = videoname,
                VideoUrl = videoUrl,
                LanguageBehaviour = languageBehaviour,
                Language = language,
                TranscriptionHint = transcriptionHint,
                ToggleDiarization = toggleDiarization,
                DiarizationNumSpeakers = diarizationNumSpeakers,
                DiarizationMinSpeakers = diarizationMinSpeakers,
                DiarizationMaxSpeakers = diarizationMaxSpeakers,
                ToggleDirectTranslate = toggleDirectTranslate,
                TargetTranslationLanguage = targetTranslationLanguage,
                OutputFormat = outputFormat,
                ToggleNoiseReduction = toggleNoiseReduction,
                ToggleAccurateWordsTimestamps = toggleAccurateWordsTimestamps,
                WebhookUrl = webhookUrl,
            };

            await VideoToTextControllerVideoTranscriptionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}