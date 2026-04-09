//HintName: G.Models.ChatCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// Model ID to use for completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestModelJsonConverter))]
        public global::G.ChatCompletionRequestModel Model { get; set; } = default!;

        /// <summary>
        /// List of messages in the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Sampling temperature (0-2). Default: 0.2<br/>
        /// Default Value: 0.2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter. Default: 1.0<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Whether to stream the response via SSE<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Up to 4 stop sequences
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Number of completion choices to generate<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// Seed for deterministic sampling (beta)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Frequency penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Presence penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Level of reasoning effort
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter))]
        public global::G.ChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Enable Wikipedia-based grounding<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wiki_grounding")]
        public bool? WikiGrounding { get; set; }

        /// <summary>
        /// List of tools the model may call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls tool invocation: none, auto, required
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter))]
        public global::G.ChatCompletionRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID to use for completion
        /// </param>
        /// <param name="messages">
        /// List of messages in the conversation
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2). Default: 0.2<br/>
        /// Default Value: 0.2
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. Default: 1.0<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response via SSE<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Up to 4 stop sequences
        /// </param>
        /// <param name="n">
        /// Number of completion choices to generate<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Seed for deterministic sampling (beta)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="reasoningEffort">
        /// Level of reasoning effort
        /// </param>
        /// <param name="wikiGrounding">
        /// Enable Wikipedia-based grounding<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call
        /// </param>
        /// <param name="toolChoice">
        /// Controls tool invocation: none, auto, required
        /// </param>
        public ChatCompletionRequest(
            global::G.ChatCompletionRequestModel model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessage> messages,
            double? temperature,
            double? topP,
            int? maxTokens,
            bool? stream,
            global::System.Collections.Generic.IList<string>? stop,
            int? n,
            int? seed,
            double? frequencyPenalty,
            double? presencePenalty,
            global::G.ChatCompletionRequestReasoningEffort? reasoningEffort,
            bool? wikiGrounding,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.ChatCompletionRequestToolChoice? toolChoice)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.Stream = stream;
            this.Stop = stop;
            this.N = n;
            this.Seed = seed;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.ReasoningEffort = reasoningEffort;
            this.WikiGrounding = wikiGrounding;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}