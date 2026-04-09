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
        [global::Newtonsoft.Json.JsonProperty("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_enabled")]
        public bool? ReasoningEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_budget")]
        public double? ReasoningBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// The successor to max_tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.ResponseFormatNullish? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.AnyOf<global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::G.ModelParamsOpenAIModelParamsToolChoiceNone?, global::G.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::G.ModelParamsOpenAIModelParamsToolChoiceFunction>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        public global::G.AnyOf<global::G.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::G.ModelParamsOpenAIModelParamsFunctionCallNone?, global::G.ModelParamsOpenAIModelParamsFunctionCallFunction>? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public double? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter))]
        public global::G.ModelParamsOpenAIModelParamsReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter))]
        public global::G.ModelParamsOpenAIModelParamsVerbosity? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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