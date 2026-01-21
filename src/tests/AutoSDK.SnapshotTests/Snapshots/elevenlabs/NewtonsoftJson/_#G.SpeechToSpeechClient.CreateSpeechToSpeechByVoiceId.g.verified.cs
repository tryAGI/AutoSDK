//HintName: G.SpeechToSpeechClient.CreateSpeechToSpeechByVoiceId.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class SpeechToSpeechClient
    {
        partial void PrepareCreateSpeechToSpeechByVoiceIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref bool? enableLogging,
            int? optimizeStreamingLatency,
            ref global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat? outputFormat,
            ref string? xiApiKey,
            global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request);
        partial void PrepareCreateSpeechToSpeechByVoiceIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            bool? enableLogging,
            int? optimizeStreamingLatency,
            global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat? outputFormat,
            string? xiApiKey,
            global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request);
        partial void ProcessCreateSpeechToSpeechByVoiceIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpeechToSpeechByVoiceIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Speech To Speech<br/>
        /// Transform audio from one voice to another. Maintain full control over emotion, timing and delivery.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Zero retention mode may only be used by enterprise customers.<br/>
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
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechToSpeechByVoiceIdAsync(
            string voiceId,
            global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request,
            bool? enableLogging = default,
            int? optimizeStreamingLatency = default,
            global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateSpeechToSpeechByVoiceIdArguments(
                httpClient: HttpClient,
                voiceId: ref voiceId,
                enableLogging: ref enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: ref outputFormat,
                xiApiKey: ref xiApiKey,
                request: request);

            var outputFormatValue = outputFormat switch
            {
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Mp32205032 => "mp3_22050_32",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Mp34410032 => "mp3_44100_32",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Mp34410064 => "mp3_44100_64",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Mp34410096 => "mp3_44100_96",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Mp344100128 => "mp3_44100_128",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Mp344100192 => "mp3_44100_192",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Pcm8000 => "pcm_8000",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Pcm16000 => "pcm_16000",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Pcm22050 => "pcm_22050",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Pcm24000 => "pcm_24000",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Pcm44100 => "pcm_44100",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Pcm48000 => "pcm_48000",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Ulaw8000 => "ulaw_8000",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Alaw8000 => "alaw_8000",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Opus4800032 => "opus_48000_32",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Opus4800064 => "opus_48000_64",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Opus4800096 => "opus_48000_96",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Opus48000128 => "opus_48000_128",
                global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat.Opus48000192 => "opus_48000_192",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/speech-to-speech/{voiceId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("enable_logging", enableLogging?.ToString()) 
                .AddOptionalParameter("optimize_streaming_latency", optimizeStreamingLatency?.ToString()) 
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

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{voiceId}"),
                name: "voice_id");
            if (enableLogging != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{enableLogging}"),
                    name: "enable_logging");
            } 
            if (optimizeStreamingLatency != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{optimizeStreamingLatency}"),
                    name: "optimize_streaming_latency");
            } 
            if (outputFormat != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{outputFormat?.ToValueString()}"),
                    name: "output_format");
            } 
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>()),
                name: "audio",
                fileName: request.Audioname ?? string.Empty);
            if (request.ModelId != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ModelId}"),
                    name: "model_id");
            } 
            if (request.VoiceSettings != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VoiceSettings}"),
                    name: "voice_settings");
            } 
            if (request.Seed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "seed");
            } 
            if (request.RemoveBackgroundNoise != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RemoveBackgroundNoise}"),
                    name: "remove_background_noise");
            } 
            if (request.FileFormat != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FileFormat}"),
                    name: "file_format");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateSpeechToSpeechByVoiceIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateSpeechToSpeechByVoiceIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
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
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
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
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessCreateSpeechToSpeechByVoiceIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Speech To Speech<br/>
        /// Transform audio from one voice to another. Maintain full control over emotion, timing and delivery.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Zero retention mode may only be used by enterprise customers.<br/>
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
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="audio">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="audioname">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for speech to speech, you can check this using the can_do_voice_conversion property.<br/>
        /// Default Value: eleven_english_sts_v2
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored settings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set, will remove the background noise from your audio input using our audio isolation model. Only applies to Voice Changer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechToSpeechByVoiceIdAsync(
            string voiceId,
            byte[] audio,
            string audioname,
            bool? enableLogging = default,
            int? optimizeStreamingLatency = default,
            global::G.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            string? modelId = default,
            string? voiceSettings = default,
            int? seed = default,
            bool? removeBackgroundNoise = default,
            global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2? fileFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost
            {
                Audio = audio,
                Audioname = audioname,
                ModelId = modelId,
                VoiceSettings = voiceSettings,
                Seed = seed,
                RemoveBackgroundNoise = removeBackgroundNoise,
                FileFormat = fileFormat,
            };

            return await CreateSpeechToSpeechByVoiceIdAsync(
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}