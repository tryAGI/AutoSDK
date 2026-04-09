//HintName: G.OpenAPIV1Client.CreateTts.g.cs

#nullable enable

namespace G
{
    public partial class OpenAPIV1Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateTtsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateTtsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateTtsSecurityRequirement0,
            };
        partial void PrepareCreateTtsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.CreateTtsModel model,
            global::G.TTSRequest request);
        partial void PrepareCreateTtsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateTtsModel model,
            global::G.TTSRequest request);
        partial void ProcessCreateTtsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Text to Speech
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/tts \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'model: s2-pro' \<br/>
        ///   --data '{<br/>
        ///     "text": "Hello! Welcome to Fish Audio.",<br/>
        ///     "reference_id": "model-id",<br/>
        ///     "temperature": 0.7,<br/>
        ///     "top_p": 0.7,<br/>
        ///     "prosody": {<br/>
        ///       "speed": 1,<br/>
        ///       "volume": 0,<br/>
        ///       "normalize_loudness": true<br/>
        ///     },<br/>
        ///     "chunk_length": 300,<br/>
        ///     "normalize": true,<br/>
        ///     "format": "mp3",<br/>
        ///     "sample_rate": 44100,<br/>
        ///     "mp3_bitrate": 128,<br/>
        ///     "latency": "normal",<br/>
        ///     "max_new_tokens": 1024,<br/>
        ///     "repetition_penalty": 1.2,<br/>
        ///     "min_chunk_length": 50,<br/>
        ///     "condition_on_previous_chunks": true,<br/>
        ///     "early_stop_threshold": 1<br/>
        ///   }'
        /// </remarks>
        public async global::System.Threading.Tasks.Task CreateTtsAsync(

            global::G.TTSRequest request,
            global::G.CreateTtsModel model = global::G.CreateTtsModel.S2Pro,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTtsArguments(
                httpClient: HttpClient,
                model: ref model,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTtsSecurityRequirements,
                operationName: "CreateTtsAsync");

            var modelValue = model switch
            {
                global::G.CreateTtsModel.S1 => "s1",
                global::G.CreateTtsModel.S2Pro => "s2-pro",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/tts",
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

            __httpRequest.Headers.TryAddWithoutValidation("model", model.ToValueString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTtsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                model: model,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTtsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // No permission -- see authorization schemes
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.CreateTtsResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateTtsResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateTtsResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateTtsResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // No payment -- see charging schemes
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.CreateTtsResponse2? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.CreateTtsResponse2.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.CreateTtsResponse2.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateTtsResponse2>(
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
            // 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::System.Collections.Generic.IList<global::G.CreateTtsResponseItem>? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CreateTtsResponseItem>?>(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CreateTtsResponseItem>?>(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::System.Collections.Generic.IList<global::G.CreateTtsResponseItem>>(
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
        /// Text to Speech
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="text">
        /// Text to convert to speech.
        /// </param>
        /// <param name="temperature">
        /// Controls expressiveness. Higher is more varied, lower is more consistent.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="topP">
        /// Controls diversity via nucleus sampling.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="references">
        /// Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2-Pro model.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.
        /// </param>
        /// <param name="referenceId">
        /// Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2-Pro model.** When using multiple speakers, use speaker tags in your text like `&lt;|speaker:0|&gt;` and `&lt;|speaker:1|&gt;` to indicate speaker changes. Example: `&lt;|speaker:0|&gt;Hello!&lt;|speaker:1|&gt;Hi there!&lt;|speaker:0|&gt;How are you?` with `reference_id: ["speaker-a-id", "speaker-b-id"]`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prosody">
        /// Speed and volume adjustments for the output.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkLength">
        /// Text segment size for processing.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="normalize">
        /// Normalizes text for English and Chinese, improving stability for numbers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="format">
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mp3Bitrate">
        /// MP3 bitrate in kbps. Only applies when format is mp3.<br/>
        /// Default Value: 128
        /// </param>
        /// <param name="opusBitrate">
        /// Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.<br/>
        /// Default Value: -1000
        /// </param>
        /// <param name="latency">
        /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
        /// Default Value: normal
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum audio tokens to generate per text chunk.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalty for repeating audio patterns. Values above 1.0 reduce repetition.<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="minChunkLength">
        /// Minimum characters before splitting into a new chunk.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="conditionOnPreviousChunks">
        /// Use previous audio as context for voice consistency.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="earlyStopThreshold">
        /// Early stopping threshold for batch processing.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTtsAsync(
            string text,
            global::G.CreateTtsModel model = global::G.CreateTtsModel.S2Pro,
            double? temperature = default,
            double? topP = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.ReferenceAudio>>, object>? references = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? referenceId = default,
            global::G.ProsodyControl? prosody = default,
            int? chunkLength = default,
            bool? normalize = default,
            global::G.TTSRequestFormat? format = default,
            int? sampleRate = default,
            int? mp3Bitrate = default,
            int? opusBitrate = default,
            global::G.TTSRequestLatency? latency = default,
            int? maxNewTokens = default,
            double? repetitionPenalty = default,
            int? minChunkLength = default,
            bool? conditionOnPreviousChunks = default,
            double? earlyStopThreshold = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TTSRequest
            {
                Text = text,
                Temperature = temperature,
                TopP = topP,
                References = references,
                ReferenceId = referenceId,
                Prosody = prosody,
                ChunkLength = chunkLength,
                Normalize = normalize,
                Format = format,
                SampleRate = sampleRate,
                Mp3Bitrate = mp3Bitrate,
                OpusBitrate = opusBitrate,
                Latency = latency,
                MaxNewTokens = maxNewTokens,
                RepetitionPenalty = repetitionPenalty,
                MinChunkLength = minChunkLength,
                ConditionOnPreviousChunks = conditionOnPreviousChunks,
                EarlyStopThreshold = earlyStopThreshold,
            };

            await CreateTtsAsync(
                model: model,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}