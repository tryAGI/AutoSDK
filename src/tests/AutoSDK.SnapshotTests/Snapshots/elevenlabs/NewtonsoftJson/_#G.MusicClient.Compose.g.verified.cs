//HintName: G.MusicClient.Compose.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class MusicClient
    {
        partial void PrepareComposeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AllowedOutputFormats? outputFormat,
            ref string? xiApiKey,
            global::G.BodyComposeMusicV1MusicPost request);
        partial void PrepareComposeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AllowedOutputFormats? outputFormat,
            string? xiApiKey,
            global::G.BodyComposeMusicV1MusicPost request);
        partial void ProcessComposeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessComposeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Compose Music<br/>
        /// Compose a song from a prompt or a composition plan.
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
        public async global::System.Threading.Tasks.Task<byte[]> ComposeAsync(

            global::G.BodyComposeMusicV1MusicPost request,
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareComposeArguments(
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
                path: "/v1/music",
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
            PrepareComposeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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
            ProcessComposeResponse(
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
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
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

                ProcessComposeResponseContent(
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
        /// Compose Music<br/>
        /// Compose a song from a prompt or a composition plan.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="prompt">
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </param>
        /// <param name="compositionPlan">
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="seed">
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </param>
        /// <param name="forceInstrumental">
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finetuneId">
        /// The ID of the finetune to use for the generation
        /// </param>
        /// <param name="usePhoneticNames">
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="respectSectionsDurations">
        /// Controls how strictly section durations in the `composition_plan` are enforced. Only used with `composition_plan`. When set to true, the model will precisely respect each section's `duration_ms` from the plan. When set to false, the model may adjust individual section durations which will generally lead to better generation quality and improved latency, while always preserving the total song duration from the plan.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="storeForInpainting">
        /// Whether to store the generated song for inpainting. Only available to enterprise clients with access to the inpainting feature.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> ComposeAsync(
            global::G.AllowedOutputFormats? outputFormat = default,
            string? xiApiKey = default,
            string? prompt = default,
            global::G.MusicPrompt? compositionPlan = default,
            int? musicLengthMs = default,
            global::G.BodyComposeMusicV1MusicPostModelId? modelId = default,
            int? seed = default,
            bool? forceInstrumental = default,
            string? finetuneId = default,
            bool? usePhoneticNames = default,
            bool? respectSectionsDurations = default,
            bool? storeForInpainting = default,
            bool? signWithC2pa = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyComposeMusicV1MusicPost
            {
                Prompt = prompt,
                CompositionPlan = compositionPlan,
                MusicLengthMs = musicLengthMs,
                ModelId = modelId,
                Seed = seed,
                ForceInstrumental = forceInstrumental,
                FinetuneId = finetuneId,
                UsePhoneticNames = usePhoneticNames,
                RespectSectionsDurations = respectSectionsDurations,
                StoreForInpainting = storeForInpainting,
                SignWithC2pa = signWithC2pa,
            };

            return await ComposeAsync(
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}