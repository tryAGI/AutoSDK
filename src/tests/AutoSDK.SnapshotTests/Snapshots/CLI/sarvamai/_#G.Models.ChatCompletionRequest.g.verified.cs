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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionRequestModel Model { get; set; }

        /// <summary>
        /// List of messages in the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionMessage> Messages { get; set; }

        /// <summary>
        /// Sampling temperature (0-2). Default: 0.2<br/>
        /// Default Value: 0.2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter. Default: 1.0<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Whether to stream the response via SSE<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Up to 4 stop sequences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Number of completion choices to generate<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Seed for deterministic sampling (beta)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Frequency penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Presence penalty (-2.0 to 2.0). Default: 0<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Level of reasoning effort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter))]
        public global::G.ChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Enable Wikipedia-based grounding<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wiki_grounding")]
        public bool? WikiGrounding { get; set; }

        /// <summary>
        /// List of tools the model may call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls tool invocation: none, auto, required
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter))]
        public global::G.ChatCompletionRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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