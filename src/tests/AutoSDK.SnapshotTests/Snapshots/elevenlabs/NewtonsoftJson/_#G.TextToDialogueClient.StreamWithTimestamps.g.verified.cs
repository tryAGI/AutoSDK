//HintName: G.TextToDialogueClient.StreamWithTimestamps.g.cs

#nullable enable

namespace G
{
    public partial class TextToDialogueClient
    {
        partial void PrepareStreamWithTimestampsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AllowedOutputFormats? outputFormat,
            ref string? xiApiKey,
            global::G.BodyTextToDialogueStreamWithTimestamps request);
        partial void PrepareStreamWithTimestampsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AllowedOutputFormats? outputFormat,
            string? xiApiKey,
            global::G.BodyTextToDialogueStreamWithTimestamps request);
        partial void ProcessStreamWithTimestampsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text To Dialogue Streaming With Timestamps<br/>
        /// Converts a list of text and voice ID pairs into speech (dialogue) and returns a stream of JSON blobs containing audio as a base64 encoded string and timestamps
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel> StreamWithTimestampsAsync(

            global::G.BodyTextToDialogueStreamWithTimestamps request,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStreamWithTimestampsArguments(
                httpClient: HttpClient,
                outputFormat: ref outputFormat,
                xiApiKey: ref xiApiKey,
                request: request);

            var outputFormatValue = outputFormat switch
            {
                global::G.AllowedOutputFormats.Mp32205032 => "mp3_22050_32",
                global::G.AllowedOutputFormats.Mp32400048 => "mp3_24000_48",
                global::G.AllowedOutputFormats.Mp34410032 => "mp3_44100_32",
                global::G.AllowedOutputFormats.Mp34410064 => "mp3_44100_64",
                global::G.AllowedOutputFormats.Mp34410096 => "mp3_44100_96",
                global::G.AllowedOutputFormats.Mp344100128 => "mp3_44100_128",
                global::G.AllowedOutputFormats.Mp344100192 => "mp3_44100_192",
                global::G.AllowedOutputFormats.Pcm8000 => "pcm_8000",
                global::G.AllowedOutputFormats.Pcm16000 => "pcm_16000",
                global::G.AllowedOutputFormats.Pcm22050 => "pcm_22050",
                global::G.AllowedOutputFormats.Pcm24000 => "pcm_24000",
                global::G.AllowedOutputFormats.Pcm32000 => "pcm_32000",
                global::G.AllowedOutputFormats.Pcm44100 => "pcm_44100",
                global::G.AllowedOutputFormats.Pcm48000 => "pcm_48000",
                global::G.AllowedOutputFormats.Ulaw8000 => "ulaw_8000",
                global::G.AllowedOutputFormats.Alaw8000 => "alaw_8000",
                global::G.AllowedOutputFormats.Opus4800032 => "opus_48000_32",
                global::G.AllowedOutputFormats.Opus4800064 => "opus_48000_64",
                global::G.AllowedOutputFormats.Opus4800096 => "opus_48000_96",
                global::G.AllowedOutputFormats.Opus48000128 => "opus_48000_128",
                global::G.AllowedOutputFormats.Opus48000192 => "opus_48000_192",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/text-to-dialogue/stream/with-timestamps",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("output_format", outputFormat?.ToValueString()) 
                ; 
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
            PrepareStreamWithTimestampsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStreamWithTimestampsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);
            using var __reader = new global::System.IO.StreamReader(__stream);

            while (!__reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                if (global::System.String.IsNullOrWhiteSpace(__content))
                {
                    continue;
                }

                var __streamedResponse = global::G.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::G.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Text To Dialogue Streaming With Timestamps<br/>
        /// Converts a list of text and voice ID pairs into speech (dialogue) and returns a stream of JSON blobs containing audio as a base64 encoded string and timestamps
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="inputs">
        /// A list of dialogue inputs, each containing text and a voice ID which will be converted into speech. The maximum number of unique voice IDs is 10.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_v3
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model and text normalization. If the model does not support provided language code, an error will be returned.
        /// </param>
        /// <param name="settings">
        /// Settings controlling the dialogue generation.
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
        /// </param>
        /// <param name="applyTextNormalization">
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel> StreamWithTimestampsAsync(
            global::System.Collections.Generic.IList<global::G.DialogueInput> inputs,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            string? modelId = default,
            string? languageCode = default,
            global::G.ModelSettingsResponseModel? settings = default,
            global::System.Collections.Generic.IList<global::G.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators = default,
            int? seed = default,
            global::G.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization? applyTextNormalization = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyTextToDialogueStreamWithTimestamps
            {
                Inputs = inputs,
                ModelId = modelId,
                LanguageCode = languageCode,
                Settings = settings,
                PronunciationDictionaryLocators = pronunciationDictionaryLocators,
                Seed = seed,
                ApplyTextNormalization = applyTextNormalization,
            };

            var __enumerable = StreamWithTimestampsAsync(
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}