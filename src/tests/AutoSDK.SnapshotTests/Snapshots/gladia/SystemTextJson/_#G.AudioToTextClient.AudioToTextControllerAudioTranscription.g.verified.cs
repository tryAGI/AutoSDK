//HintName: G.AudioToTextClient.AudioToTextControllerAudioTranscription.g.cs

#nullable enable

namespace G
{
    public partial class AudioToTextClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_AudioToTextControllerAudioTranscriptionSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "XGladiaKey",
                        Location = "Header",
                        Name = "x-gladia-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_AudioToTextControllerAudioTranscriptionSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_AudioToTextControllerAudioTranscriptionSecurityRequirement0,
            };
        partial void PrepareAudioToTextControllerAudioTranscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.AudioToTextControllerAudioTranscriptionRequest request);
        partial void PrepareAudioToTextControllerAudioTranscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AudioToTextControllerAudioTranscriptionRequest request);
        partial void ProcessAudioToTextControllerAudioTranscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AudioToTextControllerAudioTranscriptionAsync(

            global::G.AudioToTextControllerAudioTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAudioToTextControllerAudioTranscriptionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AudioToTextControllerAudioTranscriptionSecurityRequirements,
                operationName: "AudioToTextControllerAudioTranscriptionAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/audio/text/audio-transcription",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.Audio != default)
            {

                var __contentAudio = new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentAudio,
                    name: "\"audio\"",
                    fileName: request.Audioname != null ? $"\"{request.Audioname}\"" : string.Empty);
                if (__contentAudio.Headers.ContentDisposition != null)
                {
                    __contentAudio.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.AudioUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AudioUrl}"),
                    name: "\"audio_url\"");
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
            PrepareAudioToTextControllerAudioTranscriptionRequest(
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
            ProcessAudioToTextControllerAudioTranscriptionResponse(
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
        /// <param name="audio"></param>
        /// <param name="audioname"></param>
        /// <param name="audioUrl">
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
        public async global::System.Threading.Tasks.Task AudioToTextControllerAudioTranscriptionAsync(
            byte[]? audio = default,
            string? audioname = default,
            string? audioUrl = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? languageBehaviour = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguage? language = default,
            string? transcriptionHint = default,
            bool? toggleDiarization = default,
            int? diarizationNumSpeakers = default,
            int? diarizationMinSpeakers = default,
            int? diarizationMaxSpeakers = default,
            bool? toggleDirectTranslate = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? targetTranslationLanguage = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestOutputFormat? outputFormat = default,
            bool? toggleNoiseReduction = default,
            bool? toggleAccurateWordsTimestamps = default,
            string? webhookUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.AudioToTextControllerAudioTranscriptionRequest
            {
                Audio = audio,
                Audioname = audioname,
                AudioUrl = audioUrl,
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

            await AudioToTextControllerAudioTranscriptionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}