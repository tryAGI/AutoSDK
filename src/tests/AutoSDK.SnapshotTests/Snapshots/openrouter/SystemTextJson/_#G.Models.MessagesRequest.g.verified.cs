//HintName: G.Models.MessagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request schema for Anthropic Messages API endpoint
    /// </summary>
    public sealed partial class MessagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.MessagesMessageParam>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestSystemJsonConverter))]
        public global::G.MessagesRequestSystem? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.MessagesRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public double? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.MessagesRequestToolsItems>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestToolChoiceJsonConverter))]
        public global::G.MessagesRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestThinkingJsonConverter))]
        public global::G.MessagesRequestThinking? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestServiceTierJsonConverter))]
        public global::G.MessagesRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::G.MessagesOutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.MessagesRequestCacheControl? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesRequestContextManagement, object>))]
        public global::G.OneOf<global::G.MessagesRequestContextManagement, object>? ContextManagement { get; set; }

        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.MessagesRequestProvider, object>))]
        public global::G.OneOf<global::G.MessagesRequestProvider, object>? Provider { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::G.MessagesRequestPluginsItems>? Plugins { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
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
        public global::G.MessagesRequestTrace? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Controls output generation speed. When set to `fast`, uses a higher-speed inference configuration at premium pricing. Defaults to `standard` when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesRequestSpeedJsonConverter))]
        public global::G.MessagesRequestSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="metadata"></param>
        /// <param name="stopSequences"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
        /// <param name="serviceTier"></param>
        /// <param name="outputConfig">
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
        /// </param>
        /// <param name="cacheControl"></param>
        /// <param name="stream"></param>
        /// <param name="contextManagement"></param>
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
        /// <param name="models"></param>
        /// <param name="speed">
        /// Controls output generation speed. When set to `fast`, uses a higher-speed inference configuration at premium pricing. Defaults to `standard` when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequest(
            string model,
            double? maxTokens,
            global::System.Collections.Generic.IList<global::G.MessagesMessageParam>? messages,
            global::G.MessagesRequestSystem? system,
            global::G.MessagesRequestMetadata? metadata,
            global::System.Collections.Generic.IList<string>? stopSequences,
            double? temperature,
            double? topP,
            double? topK,
            global::System.Collections.Generic.IList<global::G.MessagesRequestToolsItems>? tools,
            global::G.MessagesRequestToolChoice? toolChoice,
            global::G.MessagesRequestThinking? thinking,
            global::G.MessagesRequestServiceTier? serviceTier,
            global::G.MessagesOutputConfig? outputConfig,
            global::G.MessagesRequestCacheControl? cacheControl,
            bool? stream,
            global::G.OneOf<global::G.MessagesRequestContextManagement, object>? contextManagement,
            global::G.OneOf<global::G.MessagesRequestProvider, object>? provider,
            global::System.Collections.Generic.IList<global::G.MessagesRequestPluginsItems>? plugins,
            string? user,
            string? sessionId,
            global::G.MessagesRequestTrace? trace,
            global::System.Collections.Generic.IList<string>? models,
            global::G.MessagesRequestSpeed? speed)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Messages = messages;
            this.System = system;
            this.Metadata = metadata;
            this.StopSequences = stopSequences;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Thinking = thinking;
            this.ServiceTier = serviceTier;
            this.OutputConfig = outputConfig;
            this.CacheControl = cacheControl;
            this.Stream = stream;
            this.ContextManagement = contextManagement;
            this.Provider = provider;
            this.Plugins = plugins;
            this.User = user;
            this.SessionId = sessionId;
            this.Trace = trace;
            this.Models = models;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        public MessagesRequest()
        {
        }
    }
}