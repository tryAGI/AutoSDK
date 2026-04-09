//HintName: G.IAgentsClient.CreateAgentMessageStream.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.LettaStreamingResponse> CreateAgentMessageStreamAsync(
            string agentId,

            global::G.LettaStreamingRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.LettaStreamingResponse> CreateAgentMessageStreamAsync(
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}