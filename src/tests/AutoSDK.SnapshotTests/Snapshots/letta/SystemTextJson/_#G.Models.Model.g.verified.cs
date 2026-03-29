//HintName: G.Models.Model.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// The handle for this config, in the format provider/model-name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The actual model name used by the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A human-friendly display name for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The type of the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProviderType ProviderType { get; set; }

        /// <summary>
        /// The provider name for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Type of model (llm or embedding)<br/>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Deprecated: Use 'name' field instead. LLM model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model1 { get; set; }

        /// <summary>
        /// Deprecated: Use 'provider_type' field instead. The endpoint type for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_endpoint_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelModelEndpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelModelEndpointType ModelEndpointType { get; set; }

        /// <summary>
        /// Deprecated: The endpoint for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_endpoint")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ModelEndpoint { get; set; }

        /// <summary>
        /// Deprecated: The provider category for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_category")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ProviderCategory? ProviderCategory { get; set; }

        /// <summary>
        /// Deprecated: The wrapper for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_wrapper")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ModelWrapper { get; set; }

        /// <summary>
        /// Deprecated: Use 'max_context_window' field instead. The context window size for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextWindow { get; set; }

        /// <summary>
        /// Deprecated: Puts 'inner_thoughts' as a kwarg in the function call.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("put_inner_thoughts_in_kwargs")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PutInnerThoughtsInKwargs { get; set; }

        /// <summary>
        /// Deprecated: The temperature to use when generating text with the model.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Deprecated: The maximum number of tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Deprecated: Whether or not the model should use extended thinking if it is a 'reasoning' style model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_reasoner")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnableReasoner { get; set; }

        /// <summary>
        /// Deprecated: The reasoning effort to use when generating text reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelReasoningEffort2? ReasoningEffort { get; set; }

        /// <summary>
        /// Deprecated: Configurable thinking budget for extended thinking.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_reasoning_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxReasoningTokens { get; set; }

        /// <summary>
        /// The effort level for Anthropic models that support it (Opus 4.5, Opus 4.6). Controls token spending and thinking behavior. Not setting this gives similar performance to 'high'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::G.ModelEffort2? Effort { get; set; }

        /// <summary>
        /// Deprecated: Positive values penalize new tokens based on their existing frequency in the text so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Deprecated: The framework compatibility type for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatibility_type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelCompatibilityType2? CompatibilityType { get; set; }

        /// <summary>
        /// Deprecated: Soft control for how verbose model output should be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelVerbosity2? Verbosity { get; set; }

        /// <summary>
        /// Deprecated: The cost tier for the model (cloud only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Tier { get; set; }

        /// <summary>
        /// Deprecated: If set to True, enables parallel tool calling.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The response format for the model's output. Supports text, json_object, and json_schema (structured outputs). Can be set via model_settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormatVariant110? ResponseFormat { get; set; }

        /// <summary>
        /// Enable strict mode for tool calling. When true, tool schemas include strict: true and additionalProperties: false, guaranteeing tool outputs match JSON schemas.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Whether to return log probabilities of the output tokens. Useful for RL training.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_logprobs")]
        public bool? ReturnLogprobs { get; set; }

        /// <summary>
        /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Whether to return token IDs for all LLM generations via SGLang native endpoint. Required for multi-turn RL training with loss masking. Only works with SGLang provider.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_token_ids")]
        public bool? ReturnTokenIds { get; set; }

        /// <summary>
        /// The maximum context window for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxContextWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="name">
        /// The actual model name used by the provider
        /// </param>
        /// <param name="providerType">
        /// The type of the provider
        /// </param>
        /// <param name="model1">
        /// Deprecated: Use 'name' field instead. LLM model name.
        /// </param>
        /// <param name="modelEndpointType">
        /// Deprecated: Use 'provider_type' field instead. The endpoint type for the model.
        /// </param>
        /// <param name="contextWindow">
        /// Deprecated: Use 'max_context_window' field instead. The context window size for the model.
        /// </param>
        /// <param name="maxContextWindow">
        /// The maximum context window for the model
        /// </param>
        /// <param name="handle">
        /// The handle for this config, in the format provider/model-name.
        /// </param>
        /// <param name="displayName">
        /// A human-friendly display name for the model.
        /// </param>
        /// <param name="providerName">
        /// The provider name for the model.
        /// </param>
        /// <param name="modelType">
        /// Type of model (llm or embedding)<br/>
        /// Default Value: llm
        /// </param>
        /// <param name="effort">
        /// The effort level for Anthropic models that support it (Opus 4.5, Opus 4.6). Controls token spending and thinking behavior. Not setting this gives similar performance to 'high'.
        /// </param>
        /// <param name="responseFormat">
        /// The response format for the model's output. Supports text, json_object, and json_schema (structured outputs). Can be set via model_settings.
        /// </param>
        /// <param name="strict">
        /// Enable strict mode for tool calling. When true, tool schemas include strict: true and additionalProperties: false, guaranteeing tool outputs match JSON schemas.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnLogprobs">
        /// Whether to return log probabilities of the output tokens. Useful for RL training.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
        /// </param>
        /// <param name="returnTokenIds">
        /// Whether to return token IDs for all LLM generations via SGLang native endpoint. Required for multi-turn RL training with loss masking. Only works with SGLang provider.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string name,
            global::G.ProviderType providerType,
            string model1,
            global::G.ModelModelEndpointType modelEndpointType,
            int contextWindow,
            int maxContextWindow,
            string? handle,
            string? displayName,
            string? providerName,
            string? modelType,
            global::G.ModelEffort2? effort,
            global::G.ResponseFormatVariant110? responseFormat,
            bool? strict,
            bool? returnLogprobs,
            int? topLogprobs,
            bool? returnTokenIds)
        {
            this.Handle = handle;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName;
            this.ProviderType = providerType;
            this.ProviderName = providerName;
            this.ModelType = modelType;
            this.Model1 = model1 ?? throw new global::System.ArgumentNullException(nameof(model1));
            this.ModelEndpointType = modelEndpointType;
            this.ContextWindow = contextWindow;
            this.Effort = effort;
            this.ResponseFormat = responseFormat;
            this.Strict = strict;
            this.ReturnLogprobs = returnLogprobs;
            this.TopLogprobs = topLogprobs;
            this.ReturnTokenIds = returnTokenIds;
            this.MaxContextWindow = maxContextWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}