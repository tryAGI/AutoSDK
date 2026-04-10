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
        [global::Newtonsoft.Json.JsonProperty("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The actual model name used by the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A human-friendly display name for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The type of the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderTypeJsonConverter))]
        public global::G.ProviderType ProviderType { get; set; } = default!;

        /// <summary>
        /// The provider name for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Type of model (llm or embedding)<br/>
        /// Default Value: llm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Deprecated: Use 'name' field instead. LLM model name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model1 { get; set; } = default!;

        /// <summary>
        /// Deprecated: Use 'provider_type' field instead. The endpoint type for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_endpoint_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelModelEndpointTypeJsonConverter))]
        public global::G.ModelModelEndpointType ModelEndpointType { get; set; } = default!;

        /// <summary>
        /// Deprecated: The endpoint for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_endpoint")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ModelEndpoint { get; set; }

        /// <summary>
        /// Deprecated: The provider category for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_category")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ProviderCategory? ProviderCategory { get; set; }

        /// <summary>
        /// Deprecated: The wrapper for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_wrapper")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ModelWrapper { get; set; }

        /// <summary>
        /// Deprecated: Use 'max_context_window' field instead. The context window size for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_window", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContextWindow { get; set; } = default!;

        /// <summary>
        /// Deprecated: Puts 'inner_thoughts' as a kwarg in the function call.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("put_inner_thoughts_in_kwargs")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PutInnerThoughtsInKwargs { get; set; }

        /// <summary>
        /// Deprecated: The temperature to use when generating text with the model.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Deprecated: The maximum number of tokens to generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Deprecated: Whether or not the model should use extended thinking if it is a 'reasoning' style model.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_reasoner")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnableReasoner { get; set; }

        /// <summary>
        /// Deprecated: The reasoning effort to use when generating text reasoning models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelReasoningEffort2? ReasoningEffort { get; set; }

        /// <summary>
        /// Deprecated: Configurable thinking budget for extended thinking.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_reasoning_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxReasoningTokens { get; set; }

        /// <summary>
        /// The effort level for Anthropic models that support it (Opus 4.5, Opus 4.6). Controls token spending and thinking behavior. Not setting this gives similar performance to 'high'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effort")]
        public global::G.ModelEffort2? Effort { get; set; }

        /// <summary>
        /// Deprecated: Positive values penalize new tokens based on their existing frequency in the text so far.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Deprecated: The framework compatibility type for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compatibility_type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelCompatibilityType2? CompatibilityType { get; set; }

        /// <summary>
        /// Deprecated: Soft control for how verbose model output should be.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ModelVerbosity2? Verbosity { get; set; }

        /// <summary>
        /// Deprecated: The cost tier for the model (cloud only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Tier { get; set; }

        /// <summary>
        /// Deprecated: If set to True, enables parallel tool calling.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The response format for the model's output. Supports text, json_object, and json_schema (structured outputs). Can be set via model_settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormatVariant110? ResponseFormat { get; set; }

        /// <summary>
        /// Enable strict mode for tool calling. When true, tool schemas include strict: true and additionalProperties: false, guaranteeing tool outputs match JSON schemas.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Whether to return log probabilities of the output tokens. Useful for RL training.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_logprobs")]
        public bool? ReturnLogprobs { get; set; }

        /// <summary>
        /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Whether to return token IDs for all LLM generations via SGLang native endpoint. Required for multi-turn RL training with loss masking. Only works with SGLang provider.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_token_ids")]
        public bool? ReturnTokenIds { get; set; }

        /// <summary>
        /// The maximum context window for the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_context_window", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxContextWindow { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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