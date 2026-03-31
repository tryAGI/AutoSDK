//HintName: G.LiveV2Client.StreamingControllerInitStreamingSessionV2.g.cs

#nullable enable

namespace G
{
    public partial class LiveV2Client
    {
        partial void PrepareStreamingControllerInitStreamingSessionV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.StreamingSupportedRegions? region,
            global::G.StreamingRequest request);
        partial void PrepareStreamingControllerInitStreamingSessionV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.StreamingSupportedRegions? region,
            global::G.StreamingRequest request);
        partial void ProcessStreamingControllerInitStreamingSessionV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamingControllerInitStreamingSessionV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Initiate a new live job
        /// </summary>
        /// <param name="region"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.InitStreamingResponse> StreamingControllerInitStreamingSessionV2Async(

            global::G.StreamingRequest request,
            global::G.StreamingSupportedRegions? region = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStreamingControllerInitStreamingSessionV2Arguments(
                httpClient: HttpClient,
                region: ref region,
                request: request);

            var regionValue = region switch
            {
                global::G.StreamingSupportedRegions.UsWest => "us-west",
                global::G.StreamingSupportedRegions.EuWest => "eu-west",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/live",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("region", region?.ToValueString()) 
                ; 
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStreamingControllerInitStreamingSessionV2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                region: region,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStreamingControllerInitStreamingSessionV2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Something is wrong with the request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.BadRequestErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.BadRequestErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.BadRequestErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestErrorResponse>(
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
            // You don't have the permissions to initiate a new live job
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.UnauthorizedErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.UnauthorizedErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.UnauthorizedErrorResponse.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.UnauthorizedErrorResponse>(
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
            // The parameters you gave are incorrect
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.UnprocessableEntityErrorResponse? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.UnprocessableEntityErrorResponse.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.UnprocessableEntityErrorResponse.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.UnprocessableEntityErrorResponse>(
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
                ProcessStreamingControllerInitStreamingSessionV2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.InitStreamingResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.InitStreamingResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Initiate a new live job
        /// </summary>
        /// <param name="region"></param>
        /// <param name="encoding">
        /// The encoding format of the audio stream. Supported formats: <br/>
        /// - PCM: 8, 16, 24, and 32 bits <br/>
        /// - A-law: 8 bits <br/>
        /// - μ-law: 8 bits <br/>
        /// Note: No need to add WAV headers to raw audio as the API supports both formats.<br/>
        /// Default Value: wav/pcm
        /// </param>
        /// <param name="bitDepth">
        /// The bit depth of the audio stream<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio stream<br/>
        /// Default Value: 16000
        /// </param>
        /// <param name="channels">
        /// The number of channels of the audio stream<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata you can attach to this live transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="model">
        /// The model used to process the audio. "solaria-1" is used by default.<br/>
        /// Default Value: solaria-1
        /// </param>
        /// <param name="endpointing">
        /// The endpointing duration in seconds. Endpointing is the duration of silence which will cause an utterance to be considered as finished<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="maximumDurationWithoutEndpointing">
        /// The maximum duration in seconds without endpointing. If endpointing is not detected after this duration, current utterance will be considered as finished<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="preProcessing">
        /// Specify the pre-processing configuration
        /// </param>
        /// <param name="realtimeProcessing">
        /// Specify the realtime processing configuration
        /// </param>
        /// <param name="postProcessing">
        /// Specify the post-processing configuration
        /// </param>
        /// <param name="messagesConfig">
        /// Specify the websocket messages configuration
        /// </param>
        /// <param name="callback">
        /// If true, messages will be sent to configured url.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="callbackConfig">
        /// Specify the callback configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.InitStreamingResponse> StreamingControllerInitStreamingSessionV2Async(
            global::G.StreamingSupportedRegions? region = default,
            global::G.StreamingSupportedEncodingEnum? encoding = default,
            double? bitDepth = default,
            double? sampleRate = default,
            int? channels = default,
            object? customMetadata = default,
            global::G.StreamingSupportedModels? model = default,
            double? endpointing = default,
            double? maximumDurationWithoutEndpointing = default,
            global::G.LanguageConfig? languageConfig = default,
            global::G.PreProcessingConfig? preProcessing = default,
            global::G.RealtimeProcessingConfig? realtimeProcessing = default,
            global::G.PostProcessingConfig? postProcessing = default,
            global::G.MessagesConfig? messagesConfig = default,
            bool? callback = default,
            global::G.CallbackConfig? callbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.StreamingRequest
            {
                Encoding = encoding,
                BitDepth = bitDepth,
                SampleRate = sampleRate,
                Channels = channels,
                CustomMetadata = customMetadata,
                Model = model,
                Endpointing = endpointing,
                MaximumDurationWithoutEndpointing = maximumDurationWithoutEndpointing,
                LanguageConfig = languageConfig,
                PreProcessing = preProcessing,
                RealtimeProcessing = realtimeProcessing,
                PostProcessing = postProcessing,
                MessagesConfig = messagesConfig,
                Callback = callback,
                CallbackConfig = callbackConfig,
            };

            return await StreamingControllerInitStreamingSessionV2Async(
                region: region,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}