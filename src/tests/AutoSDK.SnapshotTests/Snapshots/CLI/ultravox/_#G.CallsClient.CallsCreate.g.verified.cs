//HintName: G.CallsClient.CallsCreate.g.cs

#nullable enable

namespace G
{
    public partial class CallsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CallsCreateSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CallsCreateSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CallsCreateSecurityRequirement0,
            };
        partial void PrepareCallsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? enableGreetingPrompt,
            ref global::System.Guid? priorCallId,
            global::G.UltravoxV1StartCallRequest request);
        partial void PrepareCallsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? enableGreetingPrompt,
            global::System.Guid? priorCallId,
            global::G.UltravoxV1StartCallRequest request);
        partial void ProcessCallsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCallsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enableGreetingPrompt">
        /// Default Value: true
        /// </param>
        /// <param name="priorCallId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Call> CallsCreateAsync(

            global::G.UltravoxV1StartCallRequest request,
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCallsCreateArguments(
                httpClient: HttpClient,
                enableGreetingPrompt: ref enableGreetingPrompt,
                priorCallId: ref priorCallId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CallsCreateSecurityRequirements,
                operationName: "CallsCreateAsync");

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
                                path: "/api/calls",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("enableGreetingPrompt", enableGreetingPrompt?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("priorCallId", priorCallId?.ToString()) 
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCallsCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    enableGreetingPrompt: enableGreetingPrompt,
                    priorCallId: priorCallId,
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
                                operationId: "CallsCreate",
                                methodName: "CallsCreateAsync",
                                pathTemplate: "\"/api/calls\"",
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
                                operationId: "CallsCreate",
                                methodName: "CallsCreateAsync",
                                pathTemplate: "\"/api/calls\"",
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
                                operationId: "CallsCreate",
                                methodName: "CallsCreateAsync",
                                pathTemplate: "\"/api/calls\"",
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
                ProcessCallsCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CallsCreate",
                                methodName: "CallsCreateAsync",
                                pathTemplate: "\"/api/calls\"",
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
                                operationId: "CallsCreate",
                                methodName: "CallsCreateAsync",
                                pathTemplate: "\"/api/calls\"",
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
                                ProcessCallsCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.Call.FromJson(__content, JsonSerializerOptions) ??
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
                                        await global::G.Call.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 
        /// </summary>
        /// <param name="enableGreetingPrompt">
        /// Default Value: true
        /// </param>
        /// <param name="priorCallId"></param>
        /// <param name="systemPrompt">
        /// The system prompt provided to the model during generations.
        /// </param>
        /// <param name="temperature">
        /// The model temperature, between 0 and 1. Defaults to 0.
        /// </param>
        /// <param name="model">
        /// The model used for generations. Defaults to fixie-ai/ultravox.
        /// </param>
        /// <param name="voice">
        /// The ID (or name if unique) of the voice the agent should use for this call.
        /// </param>
        /// <param name="externalVoice">
        /// A voice not known to Ultravox Realtime that can nonetheless be used for this call.<br/>
        ///  Your account must have an API key set for the provider of the voice.<br/>
        ///  Either this or `voice` may be set, but not both.
        /// </param>
        /// <param name="languageHint">
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.
        /// </param>
        /// <param name="initialMessages">
        /// The conversation history to start from for this call.
        /// </param>
        /// <param name="joinTimeout">
        /// A timeout for joining the call. Defaults to 30 seconds.
        /// </param>
        /// <param name="maxDuration">
        /// The maximum duration of the call. Defaults to 1 hour.
        /// </param>
        /// <param name="timeExceededMessage">
        /// What the agent should say immediately before hanging up if the call's time limit is reached.
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </param>
        /// <param name="selectedTools">
        /// The tools available to the agent for (the first stage of) this call.
        /// </param>
        /// <param name="medium">
        /// The medium used for this call.
        /// </param>
        /// <param name="recordingEnabled">
        /// Whether the call should be recorded.
        /// </param>
        /// <param name="firstSpeaker">
        /// Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing<br/>
        ///  calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
        ///  Deprecated. Prefer `firstSpeakerSettings`. If both are set, they must match.
        /// </param>
        /// <param name="transcriptOptional">
        /// Indicates whether a transcript is optional for the call.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The medium to use for the call initially. May be altered by the client later.<br/>
        ///  Defaults to voice.
        /// </param>
        /// <param name="vadSettings">
        /// VAD settings for the call.
        /// </param>
        /// <param name="firstSpeakerSettings">
        /// The settings for the initial message to get a conversation started.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.<br/>
        ///  (If first_speaker is set and this is not, first_speaker will be used instead.)
        /// </param>
        /// <param name="experimentalSettings">
        /// Experimental settings for the call.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.<br/>
        ///  Keys may not start with "ultravox.", which is reserved for system-provided metadata.
        /// </param>
        /// <param name="initialState">
        /// The initial state of the call stage which is readable/writable by tools.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Call> CallsCreateAsync(
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
            string? systemPrompt = default,
            float? temperature = default,
            string? model = default,
            string? voice = default,
            global::G.UltravoxV1ExternalVoice? externalVoice = default,
            string? languageHint = default,
            global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? initialMessages = default,
            string? joinTimeout = default,
            string? maxDuration = default,
            string? timeExceededMessage = default,
            global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? inactivityMessages = default,
            global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? selectedTools = default,
            global::G.UltravoxV1CallMedium? medium = default,
            bool? recordingEnabled = default,
            global::G.UltravoxV1StartCallRequestFirstSpeaker? firstSpeaker = default,
            bool? transcriptOptional = default,
            global::G.UltravoxV1StartCallRequestInitialOutputMedium? initialOutputMedium = default,
            global::G.UltravoxV1VadSettings? vadSettings = default,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings = default,
            object? experimentalSettings = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            object? initialState = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UltravoxV1StartCallRequest
            {
                SystemPrompt = systemPrompt,
                Temperature = temperature,
                Model = model,
                Voice = voice,
                ExternalVoice = externalVoice,
                LanguageHint = languageHint,
                InitialMessages = initialMessages,
                JoinTimeout = joinTimeout,
                MaxDuration = maxDuration,
                TimeExceededMessage = timeExceededMessage,
                InactivityMessages = inactivityMessages,
                SelectedTools = selectedTools,
                Medium = medium,
                RecordingEnabled = recordingEnabled,
                FirstSpeaker = firstSpeaker,
                TranscriptOptional = transcriptOptional,
                InitialOutputMedium = initialOutputMedium,
                VadSettings = vadSettings,
                FirstSpeakerSettings = firstSpeakerSettings,
                ExperimentalSettings = experimentalSettings,
                Metadata = metadata,
                InitialState = initialState,
            };

            return await CallsCreateAsync(
                enableGreetingPrompt: enableGreetingPrompt,
                priorCallId: priorCallId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}