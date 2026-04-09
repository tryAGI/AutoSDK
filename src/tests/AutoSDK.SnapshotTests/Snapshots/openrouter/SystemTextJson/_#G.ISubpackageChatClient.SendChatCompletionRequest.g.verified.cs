//HintName: G.ISubpackageChatClient.SendChatCompletionRequest.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageChatClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResult> SendChatCompletionRequestAsync(

            global::G.ChatRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="user">
        /// Unique user identifier
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="messages">
        /// List of messages for the conversation
        /// </param>
        /// <param name="model">
        /// Model to use for completion
        /// </param>
        /// <param name="models">
        /// Models to use for completion
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0)
        /// </param>
        /// <param name="logitBias">
        /// Token logit bias adjustments
        /// </param>
        /// <param name="logprobs">
        /// Return log probabilities
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return (0-20)
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum tokens in completion
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0)
        /// </param>
        /// <param name="reasoning">
        /// Configuration options for reasoning models
        /// </param>
        /// <param name="responseFormat">
        /// Response format configuration
        /// </param>
        /// <param name="seed">
        /// Random seed for deterministic outputs
        /// </param>
        /// <param name="stop">
        /// Stop sequences (up to 4)
        /// </param>
        /// <param name="stream">
        /// Enable streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Streaming configuration options
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="toolChoice">
        /// Tool choice configuration
        /// </param>
        /// <param name="tools">
        /// Available tools for function calling
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter (0-1)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)
        /// </param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text", "image", and "audio".
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResult> SendChatCompletionRequestAsync(
            global::System.Collections.Generic.IList<global::G.ChatMessages> messages,
            global::G.OneOf<global::G.ChatRequestProvider, object>? provider = default,
            global::System.Collections.Generic.IList<global::G.ChatRequestPluginsItems>? plugins = default,
            string? user = default,
            string? sessionId = default,
            global::G.ChatRequestTrace? trace = default,
            string? model = default,
            global::System.Collections.Generic.IList<global::G.ChatModelNamesItems>? models = default,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            double? topLogprobs = default,
            double? maxCompletionTokens = default,
            double? maxTokens = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            double? presencePenalty = default,
            global::G.ChatRequestReasoning? reasoning = default,
            global::G.ChatRequestResponseFormat? responseFormat = default,
            int? seed = default,
            global::G.ChatRequestStop? stop = default,
            bool? stream = default,
            global::G.ChatStreamOptions? streamOptions = default,
            double? temperature = default,
            bool? parallelToolCalls = default,
            global::G.ChatToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.ChatFunctionTool>? tools = default,
            double? topP = default,
            global::G.ChatDebugOptions? debug = default,
            object? imageConfig = default,
            global::System.Collections.Generic.IList<global::G.ChatRequestModalitiesItems>? modalities = default,
            global::G.ChatRequestCacheControl? cacheControl = default,
            global::G.OneOf<global::G.ChatRequestServiceTier?, object>? serviceTier = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}