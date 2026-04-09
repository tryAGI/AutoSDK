//HintName: G.SttClient.SttTranscribe.g.cs

#nullable enable

namespace G
{
    public partial class SttClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_SttTranscribeSecurityRequirement0 =
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

        private static readonly global::G.EndPointSecurityRequirement s_SttTranscribeSecurityRequirement1 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_SttTranscribeSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SttTranscribeSecurityRequirement0,
                s_SttTranscribeSecurityRequirement1,
            };
        partial void PrepareSttTranscribeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.SttTranscribeCartesiaVersion cartesiaVersion,
            ref global::G.STTEncoding? encoding,
            ref int? sampleRate,
            global::G.SttTranscribeRequest request);
        partial void PrepareSttTranscribeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.SttTranscribeCartesiaVersion cartesiaVersion,
            global::G.STTEncoding? encoding,
            int? sampleRate,
            global::G.SttTranscribeRequest request);
        partial void ProcessSttTranscribeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSttTranscribeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text using Cartesia's Speech-to-Text API.<br/>
        /// Upload an audio file and receive a complete transcription response. Supports arbitrarily long audio files with automatic intelligent chunking for longer audio.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// **Response format:** Returns JSON with transcribed text, duration, and language. Include `timestamp_granularities: ["word"]` to get word-level timestamps.<br/>
        /// **Pricing:** Batch transcription is priced at **1 credit per 2 seconds** of audio processed.<br/>
        /// &lt;Note&gt;<br/>
        /// For migrating from the OpenAI SDK, see our [OpenAI Whisper to Cartesia Ink Migration Guide](/api-reference/stt/migrate-from-open-ai).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranscriptionResponse> SttTranscribeAsync(
            global::G.SttTranscribeCartesiaVersion cartesiaVersion,

            global::G.SttTranscribeRequest request,
            global::G.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSttTranscribeArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                encoding: ref encoding,
                sampleRate: ref sampleRate,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SttTranscribeSecurityRequirements,
                operationName: "SttTranscribeAsync");

            var cartesiaVersionValue = cartesiaVersion switch
            {
                global::G.SttTranscribeCartesiaVersion.x20240610 => "2024-06-10",
                global::G.SttTranscribeCartesiaVersion.x20241113 => "2024-11-13",
                global::G.SttTranscribeCartesiaVersion.x20250416 => "2025-04-16",
                global::G.SttTranscribeCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var encodingValue = encoding switch
            {
                global::G.STTEncoding.PcmS16le => "pcm_s16le",
                global::G.STTEncoding.PcmS32le => "pcm_s32le",
                global::G.STTEncoding.PcmF16le => "pcm_f16le",
                global::G.STTEncoding.PcmF32le => "pcm_f32le",
                global::G.STTEncoding.PcmMulaw => "pcm_mulaw",
                global::G.STTEncoding.PcmAlaw => "pcm_alaw",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/stt",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("encoding", encoding?.ToValueString())
                                .AddOptionalParameter("sample_rate", sampleRate?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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

                __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{cartesiaVersion.ToValueString()}"),
                                name: "\"Cartesia-Version\"");
                            if (encoding != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{encoding?.ToValueString()}"),
                                    name: "\"encoding\"");
                            } 
                            if (sampleRate != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{sampleRate}"),
                                    name: "\"sample_rate\"");
                            } 
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentFile,
                                    name: "\"file\"",
                                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                                if (__contentFile.Headers.ContentDisposition != null)
                                {
                                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Model}"),
                                    name: "\"model\"");
                            } 
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Language?.ToValueString()}"),
                                    name: "\"language\"");
                            } 
                            if (request.TimestampGranularities != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.TimestampGranularities, x => x.ToValueString()))}]"),
                                    name: "\"timestamp_granularities[]\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSttTranscribeRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cartesiaVersion: cartesiaVersion,
                    encoding: encoding,
                    sampleRate: sampleRate,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SttTranscribe",
                                methodName: "SttTranscribeAsync",
                                pathTemplate: "\"/stt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SttTranscribe",
                                methodName: "SttTranscribeAsync",
                                pathTemplate: "\"/stt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SttTranscribe",
                                methodName: "SttTranscribeAsync",
                                pathTemplate: "\"/stt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSttTranscribeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SttTranscribe",
                                methodName: "SttTranscribeAsync",
                                pathTemplate: "\"/stt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SttTranscribe",
                                methodName: "SttTranscribeAsync",
                                pathTemplate: "\"/stt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessSttTranscribeResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.TranscriptionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::G.TranscriptionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text using Cartesia's Speech-to-Text API.<br/>
        /// Upload an audio file and receive a complete transcription response. Supports arbitrarily long audio files with automatic intelligent chunking for longer audio.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// **Response format:** Returns JSON with transcribed text, duration, and language. Include `timestamp_granularities: ["word"]` to get word-level timestamps.<br/>
        /// **Pricing:** Batch transcription is priced at **1 credit per 2 seconds** of audio processed.<br/>
        /// &lt;Note&gt;<br/>
        /// For migrating from the OpenAI SDK, see our [OpenAI Whisper to Cartesia Ink Migration Guide](/api-reference/stt/migrate-from-open-ai).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model">
        /// ID of the model to use for transcription. Use `ink-whisper` for the latest Cartesia Whisper model.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranscriptionResponse> SttTranscribeAsync(
            global::G.SttTranscribeCartesiaVersion cartesiaVersion,
            global::G.STTEncoding? encoding = default,
            int? sampleRate = default,
            byte[]? file = default,
            string? filename = default,
            string? model = default,
            global::G.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::G.TimestampGranularity>? timestampGranularities = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SttTranscribeRequest
            {
                File = file,
                Filename = filename,
                Model = model,
                Language = language,
                TimestampGranularities = timestampGranularities,
            };

            return await SttTranscribeAsync(
                cartesiaVersion: cartesiaVersion,
                encoding: encoding,
                sampleRate: sampleRate,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}