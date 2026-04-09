//HintName: G.InfillClient.InfillBytes.g.cs

#nullable enable

namespace G
{
    public partial class InfillClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_InfillBytesSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "TokenAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_InfillBytesSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_InfillBytesSecurityRequirement0,
            };
        partial void PrepareInfillBytesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.InfillBytesCartesiaVersion cartesiaVersion,
            global::G.InfillBytesRequest request);
        partial void PrepareInfillBytesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.InfillBytesCartesiaVersion cartesiaVersion,
            global::G.InfillBytesRequest request);
        partial void ProcessInfillBytesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInfillBytesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.<br/>
        /// **The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:<br/>
        /// - Use longer infill transcripts<br/>
        ///   - This gives the model more flexibility to adapt to the rest of the audio<br/>
        /// - Target natural pauses in the audio when deciding where to clip<br/>
        ///   - This means you don't need word-level timestamps to be as precise<br/>
        /// - Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible<br/>
        ///   - This helps the model generate more natural transitions
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::G.InfillBytesCartesiaVersion cartesiaVersion,

            global::G.InfillBytesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInfillBytesArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InfillBytesSecurityRequirements,
                operationName: "InfillBytesAsync");

            var cartesiaVersionValue = cartesiaVersion switch
            {
                global::G.InfillBytesCartesiaVersion.x20240610 => "2024-06-10",
                global::G.InfillBytesCartesiaVersion.x20241113 => "2024-11-13",
                global::G.InfillBytesCartesiaVersion.x20250416 => "2025-04-16",
                global::G.InfillBytesCartesiaVersion.x20251104 => "2025-11-04",
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
                                path: "/infill/bytes",
                                baseUri: HttpClient.BaseAddress);
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
            }

                __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{cartesiaVersion.ToValueString()}"),
                                name: "\"Cartesia-Version\"");
                            if (request.LeftAudio != default)
                            {

                                var __contentLeftAudio = new global::System.Net.Http.ByteArrayContent(request.LeftAudio ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentLeftAudio,
                                    name: "\"left_audio\"",
                                    fileName: request.LeftAudioname != null ? $"\"{request.LeftAudioname}\"" : string.Empty);
                                if (__contentLeftAudio.Headers.ContentDisposition != null)
                                {
                                    __contentLeftAudio.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.RightAudio != default)
                            {

                                var __contentRightAudio = new global::System.Net.Http.ByteArrayContent(request.RightAudio ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentRightAudio,
                                    name: "\"right_audio\"",
                                    fileName: request.RightAudioname != null ? $"\"{request.RightAudioname}\"" : string.Empty);
                                if (__contentRightAudio.Headers.ContentDisposition != null)
                                {
                                    __contentRightAudio.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.ModelId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.ModelId}"),
                                    name: "\"model_id\"");
                            } 
                            if (request.Language != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Language}"),
                                    name: "\"language\"");
                            } 
                            if (request.Transcript != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Transcript}"),
                                    name: "\"transcript\"");
                            } 
                            if (request.VoiceId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.VoiceId}"),
                                    name: "\"voice_id\"");
                            } 
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputFormat?.ToString() ?? string.Empty),
                                    name: "\"output_format\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareInfillBytesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cartesiaVersion: cartesiaVersion,
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
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
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
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
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
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
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
                ProcessInfillBytesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
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
                                operationId: "InfillBytes",
                                methodName: "InfillBytesAsync",
                                pathTemplate: "\"/infill/bytes\"",
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
                                var __content = await __response.Content.ReadAsByteArrayAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessInfillBytesResponseContent(
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
                                        __effectiveCancellationToken
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
        /// Infill (Bytes)<br/>
        /// Generate audio that smoothly connects two existing audio segments. This is useful for inserting new speech between existing speech segments while maintaining natural transitions.<br/>
        /// **The cost is 1 credit per character of the infill text plus a fixed cost of 300 credits.**<br/>
        /// At least one of `left_audio` or `right_audio` must be provided.<br/>
        /// As with all generative models, there's some inherent variability, but here's some tips we recommend to get the best results from infill:<br/>
        /// - Use longer infill transcripts<br/>
        ///   - This gives the model more flexibility to adapt to the rest of the audio<br/>
        /// - Target natural pauses in the audio when deciding where to clip<br/>
        ///   - This means you don't need word-level timestamps to be as precise<br/>
        /// - Clip right up to the start and end of the audio segment you want infilled, keeping as much silence in the left/right audio segments as possible<br/>
        ///   - This helps the model generate more natural transitions
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="leftAudio"></param>
        /// <param name="leftAudioname"></param>
        /// <param name="rightAudio"></param>
        /// <param name="rightAudioname"></param>
        /// <param name="modelId">
        /// The ID of the model to use for generating audio. Any model other than the first `"sonic"` model is supported.
        /// </param>
        /// <param name="language">
        /// The language of the transcript
        /// </param>
        /// <param name="transcript">
        /// The infill text to generate
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to use for generating audio
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> InfillBytesAsync(
            global::G.InfillBytesCartesiaVersion cartesiaVersion,
            byte[]? leftAudio = default,
            string? leftAudioname = default,
            byte[]? rightAudio = default,
            string? rightAudioname = default,
            string? modelId = default,
            string? language = default,
            string? transcript = default,
            string? voiceId = default,
            global::G.OutputFormat? outputFormat = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.InfillBytesRequest
            {
                LeftAudio = leftAudio,
                LeftAudioname = leftAudioname,
                RightAudio = rightAudio,
                RightAudioname = rightAudioname,
                ModelId = modelId,
                Language = language,
                Transcript = transcript,
                VoiceId = voiceId,
                OutputFormat = outputFormat,
            };

            return await InfillBytesAsync(
                cartesiaVersion: cartesiaVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}