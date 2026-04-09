//HintName: G.CallsClient.SendCall.g.cs

#nullable enable

namespace G
{
    public partial class CallsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_SendCallSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_SendCallSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SendCallSecurityRequirement0,
            };
        partial void PrepareSendCallArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.SendCallRequest request);
        partial void PrepareSendCallRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.SendCallRequest request);
        partial void ProcessSendCallResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSendCallResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Send Call<br/>
        /// Send an AI phone call with a custom objective and actions. Requires either a `task` (prompt) or `pathway_id`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SendCallResponse> SendCallAsync(

            global::G.SendCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSendCallArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SendCallSecurityRequirements,
                operationName: "SendCallAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/calls",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSendCallRequest(
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
            ProcessSendCallResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation error
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.ErrorResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
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
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
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
                ProcessSendCallResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SendCallResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SendCallResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Send Call<br/>
        /// Send an AI phone call with a custom objective and actions. Requires either a `task` (prompt) or `pathway_id`.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number to call in E.164 format
        /// </param>
        /// <param name="task">
        /// Natural language instructions for the AI agent. Required if pathway_id is not provided.
        /// </param>
        /// <param name="pathwayId">
        /// ID of a conversational pathway to follow. Required if task is not provided.
        /// </param>
        /// <param name="pathwayVersion">
        /// Pathway version number to use (default is production version)
        /// </param>
        /// <param name="voice">
        /// Voice ID or preset name (e.g. Josh, Florian, Derek, June, Nat, Paige)
        /// </param>
        /// <param name="firstSentence">
        /// Specific opening phrase for the agent
        /// </param>
        /// <param name="personaId">
        /// ID of a pre-configured persona template
        /// </param>
        /// <param name="model">
        /// Model type for the call<br/>
        /// Default Value: base
        /// </param>
        /// <param name="language">
        /// Language code for transcription and speech optimization<br/>
        /// Default Value: babel-en
        /// </param>
        /// <param name="temperature">
        /// LLM randomness (0-1)<br/>
        /// Default Value: 0.7
        /// </param>
        /// <param name="waitForGreeting">
        /// Agent waits for callee to speak first<br/>
        /// Default Value: false
        /// </param>
        /// <param name="interruptionThreshold">
        /// Patience level in ms before responding (lower = quicker response)<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="from">
        /// Caller ID number (must own the number)
        /// </param>
        /// <param name="timezone">
        /// Timezone for the call (IANA format)<br/>
        /// Default Value: America/Los_Angeles
        /// </param>
        /// <param name="startTime">
        /// Scheduled time in format YYYY-MM-DD HH:MM:SS -HH:MM
        /// </param>
        /// <param name="maxDuration">
        /// Maximum call duration in minutes<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="transferPhoneNumber">
        /// Phone number for transferring to a human
        /// </param>
        /// <param name="transferList">
        /// Multiple transfer routing options keyed by department name
        /// </param>
        /// <param name="tools">
        /// Array of custom tool and knowledge base IDs
        /// </param>
        /// <param name="requestData">
        /// Custom variables available in prompts and pathways
        /// </param>
        /// <param name="backgroundTrack">
        /// Background audio track
        /// </param>
        /// <param name="noiseCancellation">
        /// Filter background noise<br/>
        /// Default Value: false
        /// </param>
        /// <param name="blockInterruptions">
        /// Prevent agent from processing user interruptions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="record">
        /// Record the call (access via recording_url)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="voicemail"></param>
        /// <param name="pronunciationGuide">
        /// Guide pronunciation of specific words
        /// </param>
        /// <param name="keywords">
        /// Words boosted in transcription (optional "word:boost" format)
        /// </param>
        /// <param name="webhook">
        /// HTTPS URL for post-call data delivery
        /// </param>
        /// <param name="webhookEvents">
        /// Event types to stream to webhook
        /// </param>
        /// <param name="metadata">
        /// Custom tracking data accessible regardless of call status
        /// </param>
        /// <param name="summaryPrompt">
        /// Custom instructions for call summary generation (max 2000 chars)
        /// </param>
        /// <param name="dispositions">
        /// Outcome tags for call classification
        /// </param>
        /// <param name="dynamicData">
        /// External API data integration configurations
        /// </param>
        /// <param name="ignoreButtonPress">
        /// Disable DTMF keypad input
        /// </param>
        /// <param name="precallDtmfSequence">
        /// DTMF digits played before call starts (0-9, *,
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SendCallResponse> SendCallAsync(
            string phoneNumber,
            string? task = default,
            string? pathwayId = default,
            int? pathwayVersion = default,
            string? voice = default,
            string? firstSentence = default,
            string? personaId = default,
            global::G.SendCallRequestModel? model = default,
            string? language = default,
            float? temperature = default,
            bool? waitForGreeting = default,
            int? interruptionThreshold = default,
            string? from = default,
            string? timezone = default,
            string? startTime = default,
            int? maxDuration = default,
            string? transferPhoneNumber = default,
            global::System.Collections.Generic.Dictionary<string, string>? transferList = default,
            global::System.Collections.Generic.IList<string>? tools = default,
            object? requestData = default,
            global::G.SendCallRequestBackgroundTrack? backgroundTrack = default,
            bool? noiseCancellation = default,
            bool? blockInterruptions = default,
            bool? record = default,
            global::G.VoicemailConfig? voicemail = default,
            global::System.Collections.Generic.IList<global::G.SendCallRequestPronunciationGuideItem>? pronunciationGuide = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            string? webhook = default,
            global::System.Collections.Generic.IList<global::G.SendCallRequestWebhookEvent>? webhookEvents = default,
            object? metadata = default,
            string? summaryPrompt = default,
            global::System.Collections.Generic.IList<string>? dispositions = default,
            global::System.Collections.Generic.IList<object>? dynamicData = default,
            bool? ignoreButtonPress = default,
            string? precallDtmfSequence = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SendCallRequest
            {
                PhoneNumber = phoneNumber,
                Task = task,
                PathwayId = pathwayId,
                PathwayVersion = pathwayVersion,
                Voice = voice,
                FirstSentence = firstSentence,
                PersonaId = personaId,
                Model = model,
                Language = language,
                Temperature = temperature,
                WaitForGreeting = waitForGreeting,
                InterruptionThreshold = interruptionThreshold,
                From = from,
                Timezone = timezone,
                StartTime = startTime,
                MaxDuration = maxDuration,
                TransferPhoneNumber = transferPhoneNumber,
                TransferList = transferList,
                Tools = tools,
                RequestData = requestData,
                BackgroundTrack = backgroundTrack,
                NoiseCancellation = noiseCancellation,
                BlockInterruptions = blockInterruptions,
                Record = record,
                Voicemail = voicemail,
                PronunciationGuide = pronunciationGuide,
                Keywords = keywords,
                Webhook = webhook,
                WebhookEvents = webhookEvents,
                Metadata = metadata,
                SummaryPrompt = summaryPrompt,
                Dispositions = dispositions,
                DynamicData = dynamicData,
                IgnoreButtonPress = ignoreButtonPress,
                PrecallDtmfSequence = precallDtmfSequence,
            };

            return await SendCallAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}