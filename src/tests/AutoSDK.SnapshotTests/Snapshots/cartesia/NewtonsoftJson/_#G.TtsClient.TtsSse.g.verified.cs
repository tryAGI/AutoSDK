//HintName: G.TtsClient.TtsSse.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class TtsClient
    {
        partial void PrepareTtsSseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.TtsSseCartesiaVersion cartesiaVersion,
            global::G.TTSSSERequest request);
        partial void PrepareTtsSseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.TtsSseCartesiaVersion cartesiaVersion,
            global::G.TTSSSERequest request);
        partial void ProcessTtsSseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text to Speech (SSE)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task TtsSseAsync(
            global::G.TtsSseCartesiaVersion cartesiaVersion,

            global::G.TTSSSERequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTtsSseArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);

            var cartesiaVersionValue = cartesiaVersion switch
            {
                global::G.TtsSseCartesiaVersion.x20240610 => "2024-06-10",
                global::G.TtsSseCartesiaVersion.x20241113 => "2024-11-13",
                global::G.TtsSseCartesiaVersion.x20250416 => "2025-04-16",
                global::G.TtsSseCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/tts/sse",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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

            __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTtsSseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cartesiaVersion: cartesiaVersion,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTtsSseResponse(
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
        /// Text to Speech (SSE)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="outputFormat"></param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="addTimestamps">
        /// Whether to return word-level timestamps. If `false` (default), no word timestamps will be produced at all. If `true`, the server will return timestamp events containing word-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="addPhonemeTimestamps">
        /// Whether to return phoneme-level timestamps. If `false` (default), no phoneme timestamps will be produced. If `true`, the server will return timestamp events containing phoneme-level timing information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useNormalizedTimestamps">
        /// Whether to use normalized timestamps (True) or original timestamps (False).
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
        /// <param name="contextId">
        /// A unique identifier for the context. You can use any unique identifier, like a UUID or human ID.<br/>
        /// Some customers use unique identifiers from their own systems (such as conversation IDs) as context IDs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TtsSseAsync(
            global::G.TtsSseCartesiaVersion cartesiaVersion,
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.SSEOutputFormat outputFormat,
            global::G.GenerationConfig? generationConfig = default,
            global::G.SupportedLanguage? language = default,
            bool? addTimestamps = default,
            bool? addPhonemeTimestamps = default,
            bool? useNormalizedTimestamps = default,
            string? pronunciationDictId = default,
            string? contextId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TTSSSERequest
            {
                ModelId = modelId,
                Transcript = transcript,
                Voice = voice,
                OutputFormat = outputFormat,
                GenerationConfig = generationConfig,
                Language = language,
                AddTimestamps = addTimestamps,
                AddPhonemeTimestamps = addPhonemeTimestamps,
                UseNormalizedTimestamps = useNormalizedTimestamps,
                PronunciationDictId = pronunciationDictId,
                ContextId = contextId,
            };

            await TtsSseAsync(
                cartesiaVersion: cartesiaVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}