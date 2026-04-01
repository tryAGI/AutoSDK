//HintName: G.Api.InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.WebRTCWorkerRequest request);
        partial void PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.WebRTCWorkerRequest request);
        partial void ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_EXPERIMENTAL_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::G.InitializeWebRTCResponse> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(

            global::G.WebRTCWorkerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/initialise_webrtc_worker",
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
            PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostRequest(
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
            ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponse(
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.InitializeWebRTCResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.InitializeWebRTCResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="workflowConfiguration"></param>
        /// <param name="isPreview">
        /// Default Value: false
        /// </param>
        /// <param name="webrtcOffer"></param>
        /// <param name="webrtcConfig"></param>
        /// <param name="webrtcTurnConfig"></param>
        /// <param name="webrtcRealtimeProcessing">
        /// Default Value: true
        /// </param>
        /// <param name="streamOutput"></param>
        /// <param name="dataOutput"></param>
        /// <param name="declaredFps"></param>
        /// <param name="rtspUrl"></param>
        /// <param name="mjpegUrl"></param>
        /// <param name="processingTimeout">
        /// Default Value: 3600
        /// </param>
        /// <param name="processingSessionStarted"></param>
        /// <param name="requestedPlan">
        /// Default Value: webrtc-gpu-small
        /// </param>
        /// <param name="requestedGpu"></param>
        /// <param name="requestedRegion"></param>
        /// <param name="workspaceId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_EXPERIMENTAL_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::G.InitializeWebRTCResponse> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(
            global::G.WorkflowConfiguration workflowConfiguration,
            global::G.WebRTCOffer webrtcOffer,
            string? apiKey = default,
            bool? isPreview = default,
            global::G.WebRTCConfig? webrtcConfig = default,
            global::G.WebRTCTURNConfig? webrtcTurnConfig = default,
            bool? webrtcRealtimeProcessing = default,
            global::System.Collections.Generic.IList<string>? streamOutput = default,
            global::System.Collections.Generic.IList<string>? dataOutput = default,
            double? declaredFps = default,
            string? rtspUrl = default,
            string? mjpegUrl = default,
            int? processingTimeout = default,
            global::System.DateTime? processingSessionStarted = default,
            string? requestedPlan = default,
            string? requestedGpu = default,
            string? requestedRegion = default,
            string? workspaceId = default,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.WebRTCWorkerRequest
            {
                ApiKey = apiKey,
                WorkflowConfiguration = workflowConfiguration,
                IsPreview = isPreview,
                WebrtcOffer = webrtcOffer,
                WebrtcConfig = webrtcConfig,
                WebrtcTurnConfig = webrtcTurnConfig,
                WebrtcRealtimeProcessing = webrtcRealtimeProcessing,
                StreamOutput = streamOutput,
                DataOutput = dataOutput,
                DeclaredFps = declaredFps,
                RtspUrl = rtspUrl,
                MjpegUrl = mjpegUrl,
                ProcessingTimeout = processingTimeout,
                ProcessingSessionStarted = processingSessionStarted,
                RequestedPlan = requestedPlan,
                RequestedGpu = requestedGpu,
                RequestedRegion = requestedRegion,
                WorkspaceId = workspaceId,
                SessionId = sessionId,
            };

            return await InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}