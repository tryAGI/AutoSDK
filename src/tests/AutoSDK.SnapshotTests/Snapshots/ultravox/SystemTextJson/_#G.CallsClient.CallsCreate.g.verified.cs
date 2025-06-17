//HintName: G.CallsClient.CallsCreate.g.cs

#nullable enable

namespace G
{
    public partial class CallsClient
    {
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Call> CallsCreateAsync(
            global::G.UltravoxV1StartCallRequest request,
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
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

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/calls",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("enableGreetingPrompt", enableGreetingPrompt?.ToString()) 
                .AddOptionalParameter("priorCallId", priorCallId?.ToString()) 
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
            PrepareCallsCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                enableGreetingPrompt: enableGreetingPrompt,
                priorCallId: priorCallId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCallsCreateResponse(
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.Call.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}