//HintName: G.TextToSpeechClient.CreateTextToSpeechByVoiceIdStream.g.cs

#nullable enable

namespace G
{
    public partial class TextToSpeechClient
    {
        partial void PrepareCreateTextToSpeechByVoiceIdStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref bool? enableLogging,
            ref int? optimizeStreamingLatency,
            ref string? outputFormat,
            ref string? xiApiKey,
            global::G.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPost request);
        partial void PrepareCreateTextToSpeechByVoiceIdStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            bool? enableLogging,
            int? optimizeStreamingLatency,
            string? outputFormat,
            string? xiApiKey,
            global::G.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPost request);
        partial void ProcessCreateTextToSpeechByVoiceIdStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextToSpeechByVoiceIdStreamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text To Speech Streaming<br/>
        /// Converts text into speech using a voice of your choice and returns audio as an audio stream.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false full privacy mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Full privacy mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
        /// 0 - default mode (no latency optimizations)<br/>
        /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
        /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
        /// 3 - max latency optimizations<br/>
        /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
        /// Defaults to None.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> CreateTextToSpeechByVoiceIdStreamAsync(
            string voiceId,
            global::G.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPost request,
            bool? enableLogging = true,
            int? optimizeStreamingLatency = default,
            string? outputFormat = "mp3_44100_128",
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTextToSpeechByVoiceIdStreamArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId,
                enableLogging: ref enableLogging,
                optimizeStreamingLatency: ref optimizeStreamingLatency,
                outputFormat: ref outputFormat,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/text-to-speech/{voiceId}/stream",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("enable_logging", enableLogging?.ToString()) 
                .AddOptionalParameter("optimize_streaming_latency", optimizeStreamingLatency?.ToString()) 
                .AddOptionalParameter("output_format", outputFormat) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTextToSpeechByVoiceIdStreamRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateTextToSpeechByVoiceIdStreamResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTextToSpeechByVoiceIdStreamResponseContent(
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
                global::G.HTTPValidationError.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Text To Speech Streaming<br/>
        /// Converts text into speech using a voice of your choice and returns audio as an audio stream.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false full privacy mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Full privacy mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
        /// 0 - default mode (no latency optimizations)<br/>
        /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
        /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
        /// 3 - max latency optimizations<br/>
        /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
        /// Defaults to None.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="text">
        /// The text that will get converted into speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_monolingual_v1
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 supports language enforcement. For other models, an error will be returned if language code is provided.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Default Value: []
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        /// <param name="previousText">
        /// The text that came before the text of the current request. Can be used to improve the flow of prosody when concatenating together multiple generations or to influence the prosody in the current generation.
        /// </param>
        /// <param name="nextText">
        /// The text that comes after the text of the current request. Can be used to improve the flow of prosody when concatenating together multiple generations or to influence the prosody in the current generation.
        /// </param>
        /// <param name="previousRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the flow of prosody when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="nextRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the flow of prosody when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.HTTPValidationError> CreateTextToSpeechByVoiceIdStreamAsync(
            string voiceId,
            string text,
            bool? enableLogging = true,
            int? optimizeStreamingLatency = default,
            string? outputFormat = "mp3_44100_128",
            string? xiApiKey = default,
            string? modelId = "eleven_monolingual_v1",
            string? languageCode = default,
            global::G.VoiceSettingsResponseModel? voiceSettings = default,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorDBModel>? pronunciationDictionaryLocators = default,
            int? seed = default,
            string? previousText = default,
            string? nextText = default,
            global::System.Collections.Generic.IList<string>? previousRequestIds = default,
            global::System.Collections.Generic.IList<string>? nextRequestIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyTextToSpeechStreamingV1TextToSpeechVoiceIdStreamPost
            {
                Text = text,
                ModelId = modelId,
                LanguageCode = languageCode,
                VoiceSettings = voiceSettings,
                PronunciationDictionaryLocators = pronunciationDictionaryLocators,
                Seed = seed,
                PreviousText = previousText,
                NextText = nextText,
                PreviousRequestIds = previousRequestIds,
                NextRequestIds = nextRequestIds,
            };

            return await CreateTextToSpeechByVoiceIdStreamAsync(
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}