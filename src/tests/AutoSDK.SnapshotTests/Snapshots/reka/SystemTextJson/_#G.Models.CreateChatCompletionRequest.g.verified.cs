//HintName: G.Models.CreateChatCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatMessageInput> Messages { get; set; }

        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Controls randomness. 0.0 is deterministic.<br/>
        /// Default Value: 0.4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Nucleus sampling threshold. Only tokens with cumulative probability up to top_p are considered.<br/>
        /// Default Value: 0.95
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Consider only top-k most probable tokens at each step.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Penalizes repeated tokens. Positive values reduce repetition.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Penalizes tokens that have appeared in the output. Positive values encourage new topics.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// A list of tools the model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Controls which tool is called by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter))]
        public global::G.CreateChatCompletionRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Configuration for the Reka Research model (reka-flash-research). Controls web search and parallel thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("research")]
        public global::G.ResearchConfig? Research { get; set; }

        /// <summary>
        /// Structured output configuration. Forces the model to return valid JSON matching a schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness. 0.0 is deterministic.<br/>
        /// Default Value: 0.4
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling threshold. Only tokens with cumulative probability up to top_p are considered.<br/>
        /// Default Value: 0.95
        /// </param>
        /// <param name="topK">
        /// Consider only top-k most probable tokens at each step.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalizes repeated tokens. Positive values reduce repetition.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="presencePenalty">
        /// Penalizes tokens that have appeared in the output. Positive values encourage new topics.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool is called by the model.
        /// </param>
        /// <param name="research">
        /// Configuration for the Reka Research model (reka-flash-research). Controls web search and parallel thinking.
        /// </param>
        /// <param name="responseFormat">
        /// Structured output configuration. Forces the model to return valid JSON matching a schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequest(
            global::System.Collections.Generic.IList<global::G.ChatMessageInput> messages,
            string model,
            double? temperature,
            int? maxTokens,
            double? topP,
            int? topK,
            double? frequencyPenalty,
            double? presencePenalty,
            bool? stream,
            int? seed,
            global::System.Collections.Generic.IList<string>? stop,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.CreateChatCompletionRequestToolChoice? toolChoice,
            global::G.ResearchConfig? research,
            global::G.ResponseFormat? responseFormat)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.TopP = topP;
            this.TopK = topK;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.Stream = stream;
            this.Seed = seed;
            this.Stop = stop;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Research = research;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}