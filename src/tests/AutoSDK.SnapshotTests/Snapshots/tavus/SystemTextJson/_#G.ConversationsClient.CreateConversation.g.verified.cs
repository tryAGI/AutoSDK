//HintName: G.ConversationsClient.CreateConversation.g.cs

#nullable enable

namespace G
{
    public partial class ConversationsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateConversationSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateConversationSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateConversationSecurityRequirement0,
            };
        partial void PrepareCreateConversationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateConversationRequest request);
        partial void PrepareCreateConversationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateConversationRequest request);
        partial void ProcessCreateConversationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateConversationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Conversation<br/>
        /// Start a real-time video conversation with your AI replica and persona. The response includes a conversation_url to join the call or embed it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateConversationResponse> CreateConversationAsync(

            global::G.CreateConversationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateConversationArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateConversationSecurityRequirements,
                operationName: "CreateConversationAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/conversations",
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
            PrepareCreateConversationRequest(
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
            ProcessCreateConversationResponse(
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
                ProcessCreateConversationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateConversationResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateConversationResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Conversation<br/>
        /// Start a real-time video conversation with your AI replica and persona. The response includes a conversation_url to join the call or embed it.
        /// </summary>
        /// <param name="personaId">
        /// The identifier of the persona to use.
        /// </param>
        /// <param name="replicaId">
        /// The identifier of the replica. Required if persona has no default replica.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callbacks.
        /// </param>
        /// <param name="conversationalContext">
        /// Additional context for the LLM.
        /// </param>
        /// <param name="customGreeting">
        /// Custom greeting message.
        /// </param>
        /// <param name="language">
        /// Conversation language or "multilingual" for auto-detection.
        /// </param>
        /// <param name="audioOnly">
        /// Start in audio-only mode.
        /// </param>
        /// <param name="maxCallDuration">
        /// Maximum call length in seconds (max 3600).
        /// </param>
        /// <param name="idleTimeout">
        /// Timeout if no participant joins.
        /// </param>
        /// <param name="participantLeftTimeout">
        /// Timeout after last participant leaves.
        /// </param>
        /// <param name="enableClosedCaptions">
        /// Enable closed captions.
        /// </param>
        /// <param name="isPrivate">
        /// Create a private conversation requiring a meeting token.
        /// </param>
        /// <param name="maxParticipantCount">
        /// Maximum number of participants.
        /// </param>
        /// <param name="applyGreenscreen">
        /// Apply green screen effect.
        /// </param>
        /// <param name="backgroundUrl">
        /// Website URL for background.
        /// </param>
        /// <param name="backgroundImageUrl">
        /// Image URL for background.
        /// </param>
        /// <param name="memoryStores">
        /// Memory store identifiers for cross-conversation memory.
        /// </param>
        /// <param name="enableRecording">
        /// Enable conversation recording.
        /// </param>
        /// <param name="recordingS3BucketRegion">
        /// AWS S3 bucket region for recordings.
        /// </param>
        /// <param name="recordingS3BucketName">
        /// AWS S3 bucket name for recordings.
        /// </param>
        /// <param name="properties"></param>
        /// <param name="documentIds">
        /// Knowledge base document IDs to make available.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateConversationResponse> CreateConversationAsync(
            string? personaId = default,
            string? replicaId = default,
            string? callbackUrl = default,
            string? conversationalContext = default,
            string? customGreeting = default,
            string? language = default,
            bool? audioOnly = default,
            int? maxCallDuration = default,
            int? idleTimeout = default,
            int? participantLeftTimeout = default,
            bool? enableClosedCaptions = default,
            bool? isPrivate = default,
            int? maxParticipantCount = default,
            bool? applyGreenscreen = default,
            string? backgroundUrl = default,
            string? backgroundImageUrl = default,
            global::System.Collections.Generic.IList<string>? memoryStores = default,
            bool? enableRecording = default,
            string? recordingS3BucketRegion = default,
            string? recordingS3BucketName = default,
            global::G.ConversationProperties? properties = default,
            global::System.Collections.Generic.IList<string>? documentIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateConversationRequest
            {
                PersonaId = personaId,
                ReplicaId = replicaId,
                CallbackUrl = callbackUrl,
                ConversationalContext = conversationalContext,
                CustomGreeting = customGreeting,
                Language = language,
                AudioOnly = audioOnly,
                MaxCallDuration = maxCallDuration,
                IdleTimeout = idleTimeout,
                ParticipantLeftTimeout = participantLeftTimeout,
                EnableClosedCaptions = enableClosedCaptions,
                IsPrivate = isPrivate,
                MaxParticipantCount = maxParticipantCount,
                ApplyGreenscreen = applyGreenscreen,
                BackgroundUrl = backgroundUrl,
                BackgroundImageUrl = backgroundImageUrl,
                MemoryStores = memoryStores,
                EnableRecording = enableRecording,
                RecordingS3BucketRegion = recordingS3BucketRegion,
                RecordingS3BucketName = recordingS3BucketName,
                Properties = properties,
                DocumentIds = documentIds,
            };

            return await CreateConversationAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}