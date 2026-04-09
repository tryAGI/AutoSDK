//HintName: G.AgentsClient.CreateAgentMessageStream.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateAgentMessageStreamSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateAgentMessageStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateAgentMessageStreamSecurityRequirement0,
            };
        partial void PrepareCreateAgentMessageStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            global::G.LettaStreamingRequest request);
        partial void PrepareCreateAgentMessageStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            global::G.LettaStreamingRequest request);
        partial void ProcessCreateAgentMessageStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAgentMessageStreamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Send Message Streaming<br/>
        /// Process a user message and return the agent's response.<br/>
        /// Deprecated: Use the `POST /{agent_id}/messages` endpoint with `streaming=true` in the request body instead.<br/>
        /// **Note:** Sending multiple concurrent requests to the same agent can lead to undefined behavior.<br/>
        /// Each agent processes messages sequentially, and concurrent requests may interleave in unexpected ways.<br/>
        /// Wait for each request to complete before sending the next one. Use separate agents or conversations for parallel processing.<br/>
        /// This endpoint accepts a message from a user and processes it through the agent.<br/>
        /// It will stream the steps of the response always, and stream the tokens if 'stream_tokens' is set to True.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.LettaStreamingResponse> CreateAgentMessageStreamAsync(
            string agentId,

            global::G.LettaStreamingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateAgentMessageStreamArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAgentMessageStreamSecurityRequirements,
                operationName: "CreateAgentMessageStreamAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/agents/{agentId}/messages/stream",
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
            PrepareCreateAgentMessageStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateAgentMessageStreamResponse(
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
                ProcessCreateAgentMessageStreamResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LettaStreamingResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.LettaStreamingResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Send Message Streaming<br/>
        /// Process a user message and return the agent's response.<br/>
        /// Deprecated: Use the `POST /{agent_id}/messages` endpoint with `streaming=true` in the request body instead.<br/>
        /// **Note:** Sending multiple concurrent requests to the same agent can lead to undefined behavior.<br/>
        /// Each agent processes messages sequentially, and concurrent requests may interleave in unexpected ways.<br/>
        /// Wait for each request to complete before sending the next one. Use separate agents or conversations for parallel processing.<br/>
        /// This endpoint accepts a message from a user and processes it through the agent.<br/>
        /// It will stream the steps of the response always, and stream the tokens if 'stream_tokens' is set to True.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="messages">
        /// The messages to be sent to the agent.
        /// </param>
        /// <param name="input">
        /// Syntactic sugar for a single user message. Equivalent to messages=[{'role': 'user', 'content': input}].
        /// </param>
        /// <param name="maxSteps">
        /// Maximum number of steps the agent should take to process the request.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="includeReturnMessageTypes">
        /// Only return specified message types in the response. If `None` (default) returns all messages.
        /// </param>
        /// <param name="clientTools">
        /// Client-side tools that the agent can call. When the agent calls a client-side tool, execution pauses and returns control to the client to execute the tool and provide the result via a ToolReturn.
        /// </param>
        /// <param name="overrideModel">
        /// Model handle to use for this request instead of the agent's default model. This allows sending a message to a different model without changing the agent's configuration.
        /// </param>
        /// <param name="includeCompactionMessages">
        /// If True, compaction events emit structured `SummaryMessage` and `EventMessage` types. If False (default), compaction messages are not included in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnLogprobs">
        /// If True, returns log probabilities of the output tokens in the response. Useful for RL training. Only supported for OpenAI-compatible providers (including SGLang).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
        /// </param>
        /// <param name="returnTokenIds">
        /// If True, returns token IDs and logprobs for ALL LLM generations in the agent step, not just the last one. Uses SGLang native /generate endpoint. Returns 'turns' field with TurnTokenData for each assistant/tool turn. Required for proper multi-turn RL training with loss masking.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streaming">
        /// If True, returns a streaming response (Server-Sent Events). If False (default), returns a complete response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamTokens">
        /// Flag to determine if individual tokens should be streamed, rather than streaming per step (only used when streaming=true).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includePings">
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts (only used when streaming=true).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="background">
        /// Whether to process the request in the background (only used when streaming=true).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.LettaStreamingResponse> CreateAgentMessageStreamAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.MessageCreate, global::G.ApprovalCreate, global::G.ToolReturnCreate>>? messages = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.InputVariant2Item5>, object>? input = default,
            int? maxSteps = default,
            global::System.Collections.Generic.IList<global::G.MessageType>? includeReturnMessageTypes = default,
            global::System.Collections.Generic.IList<global::G.ClientToolSchema>? clientTools = default,
            string? overrideModel = default,
            bool? includeCompactionMessages = default,
            bool? returnLogprobs = default,
            int? topLogprobs = default,
            bool? returnTokenIds = default,
            bool? streaming = default,
            bool? streamTokens = default,
            bool? includePings = default,
            bool? background = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.LettaStreamingRequest
            {
                Messages = messages,
                Input = input,
                MaxSteps = maxSteps,
                IncludeReturnMessageTypes = includeReturnMessageTypes,
                ClientTools = clientTools,
                OverrideModel = overrideModel,
                IncludeCompactionMessages = includeCompactionMessages,
                ReturnLogprobs = returnLogprobs,
                TopLogprobs = topLogprobs,
                ReturnTokenIds = returnTokenIds,
                Streaming = streaming,
                StreamTokens = streamTokens,
                IncludePings = includePings,
                Background = background,
            };

            return await CreateAgentMessageStreamAsync(
                agentId: agentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}