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
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LlmTypeJsonConverter))]
        public global::G.LlmType? LlmType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.Message>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LLMRequestBodyReasoningEffortJsonConverter))]
        public global::G.LLMRequestBodyReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LLMRequestBodyVerbosityJsonConverter))]
        public global::G.LLMRequestBodyVerbosity? Verbosity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::G.LLMRequestBodyToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.LLMRequestBodyResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolDetails")]
        public global::G.HeliconeEventTool? ToolDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorDBDetails")]
        public global::G.HeliconeEventVectorDB? VectorDBDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataDetails")]
        public global::G.HeliconeEventData? DataDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public double? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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