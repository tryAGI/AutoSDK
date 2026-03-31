//HintName: G.Models.ModelParamsOpenAIModelParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelParamsOpenAIModelParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_enabled")]
        public bool? ReasoningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_budget")]
        public double? ReasoningBudget { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// The successor to max_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatNullishJsonConverter))]
        public global::G.ResponseFormatNullish? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::G.ModelParamsOpenAIModelParamsToolChoiceNone?, global::G.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::G.ModelParamsOpenAIModelParamsToolChoiceFunction>))]
        public global::G.AnyOf<global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::G.ModelParamsOpenAIModelParamsToolChoiceNone?, global::G.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::G.ModelParamsOpenAIModelParamsToolChoiceFunction>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::G.ModelParamsOpenAIModelParamsFunctionCallNone?, global::G.ModelParamsOpenAIModelParamsFunctionCallFunction>))]
        public global::G.AnyOf<global::G.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::G.ModelParamsOpenAIModelParamsFunctionCallNone?, global::G.ModelParamsOpenAIModelParamsFunctionCallFunction>? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public double? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter))]
        public global::G.ModelParamsOpenAIModelParamsReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter))]
        public global::G.ModelParamsOpenAIModelParamsVerbosity? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParams" /> class.
        /// </summary>
        /// <param name="useCache"></param>
        /// <param name="reasoningEnabled"></param>
        /// <param name="reasoningBudget"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens">
        /// The successor to max_tokens
        /// </param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="toolChoice"></param>
        /// <param name="functionCall"></param>
        /// <param name="n"></param>
        /// <param name="stop"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="verbosity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParamsOpenAIModelParams(
            bool? useCache,
            bool? reasoningEnabled,
            double? reasoningBudget,
            double? temperature,
            double? topP,
            double? maxTokens,
            double? maxCompletionTokens,
            double? frequencyPenalty,
            double? presencePenalty,
            global::G.ResponseFormatNullish? responseFormat,
            global::G.AnyOf<global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::G.ModelParamsOpenAIModelParamsToolChoiceNone?, global::G.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::G.ModelParamsOpenAIModelParamsToolChoiceFunction>? toolChoice,
            global::G.AnyOf<global::G.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::G.ModelParamsOpenAIModelParamsFunctionCallNone?, global::G.ModelParamsOpenAIModelParamsFunctionCallFunction>? functionCall,
            double? n,
            global::System.Collections.Generic.IList<string>? stop,
            global::G.ModelParamsOpenAIModelParamsReasoningEffort? reasoningEffort,
            global::G.ModelParamsOpenAIModelParamsVerbosity? verbosity)
        {
            this.UseCache = useCache;
            this.ReasoningEnabled = reasoningEnabled;
            this.ReasoningBudget = reasoningBudget;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.ToolChoice = toolChoice;
            this.FunctionCall = functionCall;
            this.N = n;
            this.Stop = stop;
            this.ReasoningEffort = reasoningEffort;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParamsOpenAIModelParams" /> class.
        /// </summary>
        public ModelParamsOpenAIModelParams()
        {
        }
    }
}