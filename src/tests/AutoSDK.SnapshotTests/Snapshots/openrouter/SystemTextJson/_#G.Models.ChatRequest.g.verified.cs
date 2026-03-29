//HintName: G.Models.ChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chat completion request parameters
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ChatRequestProvider, object>))]
        public global::G.OneOf<global::G.ChatRequestProvider, object>? Provider { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::G.ChatRequestPluginsItems>? Plugins { get; set; }

        /// <summary>
        /// Unique user identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::G.ChatRequestTrace? Trace { get; set; }

        /// <summary>
        /// List of messages for the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatMessages> Messages { get; set; }

        /// <summary>
        /// Model to use for completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Models to use for completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::G.ChatModelNamesItems>? Models { get; set; }

        /// <summary>
        /// Frequency penalty (-2.0 to 2.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Token logit bias adjustments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// Return log probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// Number of top log probabilities to return (0-20)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public double? TopLogprobs { get; set; }

        /// <summary>
        /// Maximum tokens in completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Presence penalty (-2.0 to 2.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Configuration options for reasoning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::G.ChatRequestReasoning? Reasoning { get; set; }

        /// <summary>
        /// Response format configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestResponseFormatJsonConverter))]
        public global::G.ChatRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Random seed for deterministic outputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Stop sequences (up to 4)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestStopJsonConverter))]
        public global::G.ChatRequestStop? Stop { get; set; }

        /// <summary>
        /// Enable streaming response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Streaming configuration options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::G.ChatStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Sampling temperature (0-2)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Tool choice configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatToolChoiceJsonConverter))]
        public global::G.ChatToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Available tools for function calling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatFunctionTool>? Tools { get; set; }

        /// <summary>
        /// Nucleus sampling parameter (0-1)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Debug options for inspecting request transformations (streaming only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public global::G.ChatDebugOptions? Debug { get; set; }

        /// <summary>
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_config")]
        public object? ImageConfig { get; set; }

        /// <summary>
        /// Output modalities for the response. Supported values are "text", "image", and "audio".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::G.ChatRequestModalitiesItems>? Modalities { get; set; }

        /// <summary>
        /// Enable automatic prompt caching. When set, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.ChatRequestCacheControl? CacheControl { get; set; }

        /// <summary>
        /// The service tier to use for processing this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ChatRequestServiceTier?, object>))]
        public global::G.OneOf<global::G.ChatRequestServiceTier?, object>? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of messages for the conversation
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequest(
            global::System.Collections.Generic.IList<global::G.ChatMessages> messages,
            global::G.OneOf<global::G.ChatRequestProvider, object>? provider,
            global::System.Collections.Generic.IList<global::G.ChatRequestPluginsItems>? plugins,
            string? user,
            string? sessionId,
            global::G.ChatRequestTrace? trace,
            string? model,
            global::System.Collections.Generic.IList<global::G.ChatModelNamesItems>? models,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            double? topLogprobs,
            double? maxCompletionTokens,
            double? maxTokens,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? presencePenalty,
            global::G.ChatRequestReasoning? reasoning,
            global::G.ChatRequestResponseFormat? responseFormat,
            int? seed,
            global::G.ChatRequestStop? stop,
            bool? stream,
            global::G.ChatStreamOptions? streamOptions,
            double? temperature,
            bool? parallelToolCalls,
            global::G.ChatToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.ChatFunctionTool>? tools,
            double? topP,
            global::G.ChatDebugOptions? debug,
            object? imageConfig,
            global::System.Collections.Generic.IList<global::G.ChatRequestModalitiesItems>? modalities,
            global::G.ChatRequestCacheControl? cacheControl,
            global::G.OneOf<global::G.ChatRequestServiceTier?, object>? serviceTier)
        {
            this.Provider = provider;
            this.Plugins = plugins;
            this.User = user;
            this.SessionId = sessionId;
            this.Trace = trace;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.Models = models;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxTokens = maxTokens;
            this.Metadata = metadata;
            this.PresencePenalty = presencePenalty;
            this.Reasoning = reasoning;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.ParallelToolCalls = parallelToolCalls;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopP = topP;
            this.Debug = debug;
            this.ImageConfig = imageConfig;
            this.Modalities = modalities;
            this.CacheControl = cacheControl;
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        public ChatRequest()
        {
        }
    }
}