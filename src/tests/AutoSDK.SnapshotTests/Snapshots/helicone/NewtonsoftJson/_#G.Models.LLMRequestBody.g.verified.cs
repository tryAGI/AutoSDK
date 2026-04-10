//HintName: G.Models.LLMRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LlmTypeJsonConverter))]
        public global::G.LlmType? LlmType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.Message>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public double? MaxTokens { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMRequestBodyReasoningEffortJsonConverter))]
        public global::G.LLMRequestBodyReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMRequestBodyVerbosityJsonConverter))]
        public global::G.LLMRequestBodyVerbosity? Verbosity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.LLMRequestBodyToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.LLMRequestBodyResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolDetails")]
        public global::G.HeliconeEventTool? ToolDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorDBDetails")]
        public global::G.HeliconeEventVectorDB? VectorDBDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataDetails")]
        public global::G.HeliconeEventData? DataDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public double? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public string? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMRequestBody" /> class.
        /// </summary>
        /// <param name="llmType"></param>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="prompt"></param>
        /// <param name="instructions"></param>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="seed"></param>
        /// <param name="stream"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="stop"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="verbosity"></param>
        /// <param name="tools"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="toolDetails"></param>
        /// <param name="vectorDBDetails"></param>
        /// <param name="dataDetails"></param>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <param name="size"></param>
        /// <param name="quality"></param>
        public LLMRequestBody(
            global::G.LlmType? llmType,
            string? provider,
            string? model,
            global::System.Collections.Generic.IList<global::G.Message>? messages,
            string? prompt,
            string? instructions,
            double? maxTokens,
            double? temperature,
            double? topP,
            double? seed,
            bool? stream,
            double? presencePenalty,
            double? frequencyPenalty,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? stop,
            global::G.LLMRequestBodyReasoningEffort? reasoningEffort,
            global::G.LLMRequestBodyVerbosity? verbosity,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            bool? parallelToolCalls,
            global::G.LLMRequestBodyToolChoice? toolChoice,
            global::G.LLMRequestBodyResponseFormat? responseFormat,
            global::G.HeliconeEventTool? toolDetails,
            global::G.HeliconeEventVectorDB? vectorDBDetails,
            global::G.HeliconeEventData? dataDetails,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? input,
            double? n,
            string? size,
            string? quality)
        {
            this.LlmType = llmType;
            this.Provider = provider;
            this.Model = model;
            this.Messages = messages;
            this.Prompt = prompt;
            this.Instructions = instructions;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Seed = seed;
            this.Stream = stream;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.Stop = stop;
            this.ReasoningEffort = reasoningEffort;
            this.Verbosity = verbosity;
            this.Tools = tools;
            this.ParallelToolCalls = parallelToolCalls;
            this.ToolChoice = toolChoice;
            this.ResponseFormat = responseFormat;
            this.ToolDetails = toolDetails;
            this.VectorDBDetails = vectorDBDetails;
            this.DataDetails = dataDetails;
            this.Input = input;
            this.N = n;
            this.Size = size;
            this.Quality = quality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMRequestBody" /> class.
        /// </summary>
        public LLMRequestBody()
        {
        }
    }
}