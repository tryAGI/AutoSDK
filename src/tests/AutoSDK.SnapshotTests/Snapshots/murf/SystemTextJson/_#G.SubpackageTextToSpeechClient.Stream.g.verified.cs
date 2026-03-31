//HintName: G.SubpackageTextToSpeechClient.Stream.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageTextToSpeechClient
    {
        partial void PrepareStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.GenerateSpeechStreamingRequest request);
        partial void PrepareStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.GenerateSpeechStreamingRequest request);
        partial void ProcessStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech with ultra-low latency over a streaming connection.<br/>
        /// Choose the `Base URL` from the URL dropdown (Global URL or a pinned Region)<br/>
        /// **Note**: Global URL auto-routes to the nearest region.<br/>
        /// | Region         | URL                                       | Default Concurrency |<br/>
        /// | ------------------------- | ---------------------------------------------- | -------------------- |<br/>
        /// | Global (Routes to the nearest server) | `https://global.api.murf.ai/v1/speech/stream`     | Region specific concurrency |<br/>
        /// | US-East                   | `https://us-east.api.murf.ai/v1/speech/stream`    | 15 |<br/>
        /// | US-West                   | `https://us-west.api.murf.ai/v1/speech/stream`    | 2 |<br/>
        /// | India                     | `https://in.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Canada                    | `https://ca.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South Korea               | `https://kr.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | UAE                       | `https://me.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Japan                     | `https://jp.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Australia                 | `https://au.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | EU (Central)              | `https://eu-central.api.murf.ai/v1/speech/stream` | 2 |<br/>
        /// | UK                        | `https://uk.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South America (São Paulo) | `https://sa-east.api.murf.ai/v1/speech/stream`    | 2 |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TextToSpeechStreamResponse200> StreamAsync(

            global::G.GenerateSpeechStreamingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStreamArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/speech/stream",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStreamRequest(
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
            ProcessStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.StreamResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.StreamResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.StreamResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.StreamResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Expired subscription or character limit exhausted
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.StreamResponse2? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.StreamResponse2.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.StreamResponse2.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.StreamResponse2>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Invalid or expired token/api-key provided
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.StreamResponse3? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.StreamResponse3.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.StreamResponse3.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.StreamResponse3>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.StreamResponse4? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.StreamResponse4.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.StreamResponse4.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.StreamResponse4>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Service Unavailable
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::System.Exception? __exception_503 = null;
                global::G.StreamResponse5? __value_503 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_503 = global::G.StreamResponse5.FromJson(__content_503, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_503 = global::G.StreamResponse5.FromJson(__content_503, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_503 = __ex;
                }

                throw new global::G.ApiException<global::G.StreamResponse5>(
                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_503,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
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
                ProcessStreamResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TextToSpeechStreamResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TextToSpeechStreamResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Stream Speech<br/>
        /// Synthesize speech with ultra-low latency over a streaming connection.<br/>
        /// Choose the `Base URL` from the URL dropdown (Global URL or a pinned Region)<br/>
        /// **Note**: Global URL auto-routes to the nearest region.<br/>
        /// | Region         | URL                                       | Default Concurrency |<br/>
        /// | ------------------------- | ---------------------------------------------- | -------------------- |<br/>
        /// | Global (Routes to the nearest server) | `https://global.api.murf.ai/v1/speech/stream`     | Region specific concurrency |<br/>
        /// | US-East                   | `https://us-east.api.murf.ai/v1/speech/stream`    | 15 |<br/>
        /// | US-West                   | `https://us-west.api.murf.ai/v1/speech/stream`    | 2 |<br/>
        /// | India                     | `https://in.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Canada                    | `https://ca.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South Korea               | `https://kr.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | UAE                       | `https://me.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Japan                     | `https://jp.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Australia                 | `https://au.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | EU (Central)              | `https://eu-central.api.murf.ai/v1/speech/stream` | 2 |<br/>
        /// | UK                        | `https://uk.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South America (São Paulo) | `https://sa-east.api.murf.ai/v1/speech/stream`    | 2 |
        /// </summary>
        /// <param name="model">
        /// The model to use for audio output. Defaults to FALCON for all the regions except US-East. Valid values: FALCON, GEN2
        /// </param>
        /// <param name="channelType">
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </param>
        /// <param name="format">
        /// Format of the generated audio file.Valid values: MP3, FLAC, WAV, ALAW, ULAW, OGG, PCM<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="multiNativeLocale">
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="locale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="pitch">
        /// Pitch of the voiceover
        /// </param>
        /// <param name="pronunciationDictionary">
        /// An object used to define custom pronunciations. <br/>
        ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
        ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
        /// </param>
        /// <param name="rate">
        /// Speed of the voiceover
        /// </param>
        /// <param name="sampleRate">
        /// Valid values are 8000, 16000, 24000, 44100, 48000. Defaults to 24000 for Falcon model and 44100 for Gen2 model.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="style">
        /// The voice style to be used for voiceover generation.
        /// </param>
        /// <param name="text">
        /// The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'
        /// </param>
        /// <param name="variation">
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="voiceId">
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TextToSpeechStreamResponse200> StreamAsync(
            string text,
            string voiceId,
            string? model = default,
            string? channelType = default,
            string? format = default,
            string? multiNativeLocale = default,
            string? locale = default,
            int? pitch = default,
            global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? pronunciationDictionary = default,
            int? rate = default,
            double? sampleRate = default,
            string? style = default,
            int? variation = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.GenerateSpeechStreamingRequest
            {
                Model = model,
                ChannelType = channelType,
                Format = format,
                MultiNativeLocale = multiNativeLocale,
                Locale = locale,
                Pitch = pitch,
                PronunciationDictionary = pronunciationDictionary,
                Rate = rate,
                SampleRate = sampleRate,
                Style = style,
                Text = text,
                Variation = variation,
                VoiceId = voiceId,
            };

            return await StreamAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}