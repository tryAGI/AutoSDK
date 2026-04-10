//HintName: G.Models.OpenAIChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Simplified interface for the OpenAI Chat request format
    /// </summary>
    public sealed partial class OpenAIChatRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OpenAIChatRequestMessage>? Messages { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.OpenAIChatRequestTool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.AnyOf<global::G.OpenAIChatRequestToolChoiceEnum, global::G.OpenAIChatRequestToolChoiceEnum2?>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAIChatRequestReasoningEffortJsonConverter))]
        public global::G.OpenAIChatRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAIChatRequestVerbosityJsonConverter))]
        public global::G.OpenAIChatRequestVerbosity? Verbosity { get; set; }

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
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs")]
        public double? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public double? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<string>? Modalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prediction")]
        public object? Prediction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public object? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.OpenAIChatRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_options")]
        public object? StreamOptions { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        public global::G.AnyOf<string, global::G.OpenAIChatRequestFunctionCall>? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions")]
        public global::System.Collections.Generic.IList<object>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="stream"></param>
        /// <param name="stop"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="verbosity"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="logitBias">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="n"></param>
        /// <param name="modalities"></param>
        /// <param name="prediction"></param>
        /// <param name="audio"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="serviceTier"></param>
        /// <param name="store"></param>
        /// <param name="streamOptions"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="user"></param>
        /// <param name="functionCall"></param>
        /// <param name="functions"></param>
        public OpenAIChatRequest(
            string? model,
            global::System.Collections.Generic.IList<global::G.OpenAIChatRequestMessage>? messages,
            double? temperature,
            double? topP,
            double? maxTokens,
            double? maxCompletionTokens,
            bool? stream,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? stop,
            global::System.Collections.Generic.IList<global::G.OpenAIChatRequestTool>? tools,
            global::G.AnyOf<global::G.OpenAIChatRequestToolChoiceEnum, global::G.OpenAIChatRequestToolChoiceEnum2?>? toolChoice,
            bool? parallelToolCalls,
            global::G.OpenAIChatRequestReasoningEffort? reasoningEffort,
            global::G.OpenAIChatRequestVerbosity? verbosity,
            double? frequencyPenalty,
            double? presencePenalty,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            double? topLogprobs,
            double? n,
            global::System.Collections.Generic.IList<string>? modalities,
            object? prediction,
            object? audio,
            global::G.OpenAIChatRequestResponseFormat? responseFormat,
            double? seed,
            string? serviceTier,
            bool? store,
            object? streamOptions,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? user,
            global::G.AnyOf<string, global::G.OpenAIChatRequestFunctionCall>? functionCall,
            global::System.Collections.Generic.IList<object>? functions)
        {
            this.Model = model;
            this.Messages = messages;
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.Stream = stream;
            this.Stop = stop;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.ReasoningEffort = reasoningEffort;
            this.Verbosity = verbosity;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.N = n;
            this.Modalities = modalities;
            this.Prediction = prediction;
            this.Audio = audio;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.ServiceTier = serviceTier;
            this.Store = store;
            this.StreamOptions = streamOptions;
            this.Metadata = metadata;
            this.User = user;
            this.FunctionCall = functionCall;
            this.Functions = functions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequest" /> class.
        /// </summary>
        public OpenAIChatRequest()
        {
        }
    }
}