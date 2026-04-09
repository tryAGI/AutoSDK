//HintName: G.Models.LLMConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for Language Model (LLM) connection and generation parameters.<br/>
    /// .. deprecated::<br/>
    ///     LLMConfig is deprecated and should not be used as an input or return type in API calls.<br/>
    ///     Use the schemas in letta.schemas.model (ModelSettings, OpenAIModelSettings, etc.) instead.<br/>
    ///     For conversion, use the _to_model() method or Model._from_llm_config() method.
    /// </summary>
    public sealed partial class LLMConfig
    {
        /// <summary>
        /// LLM model name. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// A human-friendly display name for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The endpoint type for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_endpoint_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMConfigModelEndpointTypeJsonConverter))]
        public global::G.LLMConfigModelEndpointType ModelEndpointType { get; set; } = default!;

        /// <summary>
        /// The endpoint for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_endpoint")]
        public string? ModelEndpoint { get; set; }

        /// <summary>
        /// The provider name for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// The provider category for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_category")]
        public global::G.ProviderCategory? ProviderCategory { get; set; }

        /// <summary>
        /// The wrapper for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_wrapper")]
        public string? ModelWrapper { get; set; }

        /// <summary>
        /// The context window size for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_window", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContextWindow { get; set; } = default!;

        /// <summary>
        /// Puts 'inner_thoughts' as a kwarg in the function call if this is set to True. This helps with function calling performance and also the generation of inner thoughts.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("put_inner_thoughts_in_kwargs")]
        public bool? PutInnerThoughtsInKwargs { get; set; }

        /// <summary>
        /// The handle for this config, in the format provider/model-name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The temperature to use when generating text with the model. A higher temperature will result in more random text.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate. If not set, the model will use its default value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Whether or not the model should use extended thinking if it is a 'reasoning' style model<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_reasoner")]
        public bool? EnableReasoner { get; set; }

        /// <summary>
        /// The reasoning effort to use when generating text reasoning models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        public global::G.LLMConfigReasoningEffort2? ReasoningEffort { get; set; }

        /// <summary>
        /// Configurable thinking budget for extended thinking. Used for enable_reasoner and also for Google Vertex models like Gemini 2.5 Flash. Minimum value is 1024 when used with enable_reasoner.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_reasoning_tokens")]
        public int? MaxReasoningTokens { get; set; }

        /// <summary>
        /// The effort level for Anthropic models that support it (Opus 4.5, Opus 4.6). Controls token spending and thinking behavior. Not setting this gives similar performance to 'high'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effort")]
        public global::G.LLMConfigEffort2? Effort { get; set; }

        /// <summary>
        /// Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim. From OpenAI: Number between -2.0 and 2.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// The framework compatibility type for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compatibility_type")]
        public global::G.LLMConfigCompatibilityType2? CompatibilityType { get; set; }

        /// <summary>
        /// Soft control for how verbose model output should be, used for GPT-5 models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        public global::G.LLMConfigVerbosity2? Verbosity { get; set; }

        /// <summary>
        /// The cost tier for the model (cloud only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// Deprecated: Use model_settings to configure parallel tool calls instead. If set to True, enables parallel tool calling. Defaults to False.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The response format for the model's output. Supports text, json_object, and json_schema (structured outputs). Can be set via model_settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormatVariant19? ResponseFormat { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// LLM model name. 
        /// </param>
        /// <param name="modelEndpointType">
        /// The endpoint type for the model.
        /// </param>
        /// <param name="contextWindow">
        /// The context window size for the model.
        /// </param>
        /// <param name="displayName">
        /// A human-friendly display name for the model.
        /// </param>
        /// <param name="modelEndpoint">
        /// The endpoint for the model.
        /// </param>
        /// <param name="providerName">
        /// The provider name for the model.
        /// </param>
        /// <param name="providerCategory">
        /// The provider category for the model.
        /// </param>
        /// <param name="modelWrapper">
        /// The wrapper for the model.
        /// </param>
        /// <param name="putInnerThoughtsInKwargs">
        /// Puts 'inner_thoughts' as a kwarg in the function call if this is set to True. This helps with function calling performance and also the generation of inner thoughts.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="handle">
        /// The handle for this config, in the format provider/model-name.
        /// </param>
        /// <param name="temperature">
        /// The temperature to use when generating text with the model. A higher temperature will result in more random text.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate. If not set, the model will use its default value.
        /// </param>
        /// <param name="enableReasoner">
        /// Whether or not the model should use extended thinking if it is a 'reasoning' style model<br/>
        /// Default Value: true
        /// </param>
        /// <param name="reasoningEffort">
        /// The reasoning effort to use when generating text reasoning models
        /// </param>
        /// <param name="maxReasoningTokens">
        /// Configurable thinking budget for extended thinking. Used for enable_reasoner and also for Google Vertex models like Gemini 2.5 Flash. Minimum value is 1024 when used with enable_reasoner.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="effort">
        /// The effort level for Anthropic models that support it (Opus 4.5, Opus 4.6). Controls token spending and thinking behavior. Not setting this gives similar performance to 'high'.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim. From OpenAI: Number between -2.0 and 2.0.
        /// </param>
        /// <param name="compatibilityType">
        /// The framework compatibility type for the model.
        /// </param>
        /// <param name="verbosity">
        /// Soft control for how verbose model output should be, used for GPT-5 models.
        /// </param>
        /// <param name="tier">
        /// The cost tier for the model (cloud only).
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
        public LLMConfig(
            string model,
            global::G.LLMConfigModelEndpointType modelEndpointType,
            int contextWindow,
            string? displayName,
            string? modelEndpoint,
            string? providerName,
            global::G.ProviderCategory? providerCategory,
            string? modelWrapper,
            bool? putInnerThoughtsInKwargs,
            string? handle,
            double? temperature,
            int? maxTokens,
            bool? enableReasoner,
            global::G.LLMConfigReasoningEffort2? reasoningEffort,
            int? maxReasoningTokens,
            global::G.LLMConfigEffort2? effort,
            double? frequencyPenalty,
            global::G.LLMConfigCompatibilityType2? compatibilityType,
            global::G.LLMConfigVerbosity2? verbosity,
            string? tier,
            global::G.ResponseFormatVariant19? responseFormat,
            bool? strict,
            bool? returnLogprobs,
            int? topLogprobs,
            bool? returnTokenIds)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.DisplayName = displayName;
            this.ModelEndpointType = modelEndpointType;
            this.ModelEndpoint = modelEndpoint;
            this.ProviderName = providerName;
            this.ProviderCategory = providerCategory;
            this.ModelWrapper = modelWrapper;
            this.ContextWindow = contextWindow;
            this.PutInnerThoughtsInKwargs = putInnerThoughtsInKwargs;
            this.Handle = handle;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.EnableReasoner = enableReasoner;
            this.ReasoningEffort = reasoningEffort;
            this.MaxReasoningTokens = maxReasoningTokens;
            this.Effort = effort;
            this.FrequencyPenalty = frequencyPenalty;
            this.CompatibilityType = compatibilityType;
            this.Verbosity = verbosity;
            this.Tier = tier;
            this.ResponseFormat = responseFormat;
            this.Strict = strict;
            this.ReturnLogprobs = returnLogprobs;
            this.TopLogprobs = topLogprobs;
            this.ReturnTokenIds = returnTokenIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfig" /> class.
        /// </summary>
        public LLMConfig()
        {
        }
    }
}