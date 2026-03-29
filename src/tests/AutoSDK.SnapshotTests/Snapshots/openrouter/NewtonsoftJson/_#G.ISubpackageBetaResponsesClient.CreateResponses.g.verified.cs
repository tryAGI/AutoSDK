//HintName: G.ISubpackageBetaResponsesClient.CreateResponses.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageBetaResponsesClient
    {
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenResponsesResult> CreateResponsesAsync(

            global::G.ResponsesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="input">
        /// Input for a response request - can be a string or array of items
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity
        /// </param>
        /// <param name="reasoning">
        /// Configuration for reasoning mode in the response
        /// </param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="topK"></param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/features/multimodal/image-generation for more details.
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text" and "image".
        /// </param>
        /// <param name="promptCacheKey"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="prompt"></param>
        /// <param name="include"></param>
        /// <param name="background"></param>
        /// <param name="safetyIdentifier"></param>
        /// <param name="store"></param>
        /// <param name="serviceTier"></param>
        /// <param name="truncation"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenResponsesResult> CreateResponsesAsync(
            global::G.Inputs? input = default,
            string? instructions = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::G.ResponsesRequestToolsItems>? tools = default,
            global::G.OpenAIResponsesToolChoice? toolChoice = default,
            bool? parallelToolCalls = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::G.TextExtendedConfig? text = default,
            global::G.ReasoningConfig? reasoning = default,
            double? maxOutputTokens = default,
            double? temperature = default,
            double? topP = default,
            int? topLogprobs = default,
            int? maxToolCalls = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            double? topK = default,
            object? imageConfig = default,
            global::System.Collections.Generic.IList<global::G.OutputModalityEnum>? modalities = default,
            string? promptCacheKey = default,
            string? previousResponseId = default,
            global::G.StoredPromptTemplate? prompt = default,
            global::System.Collections.Generic.IList<global::G.ResponseIncludesEnum>? include = default,
            bool? background = default,
            string? safetyIdentifier = default,
            bool? store = default,
            global::G.OneOf<global::G.ResponsesRequestServiceTier?, object>? serviceTier = default,
            global::G.OpenAIResponsesTruncation? truncation = default,
            bool? stream = default,
            global::G.OneOf<global::G.ResponsesRequestProvider, object>? provider = default,
            global::System.Collections.Generic.IList<global::G.ResponsesRequestPluginsItems>? plugins = default,
            string? user = default,
            string? sessionId = default,
            global::G.ResponsesRequestTrace? trace = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}