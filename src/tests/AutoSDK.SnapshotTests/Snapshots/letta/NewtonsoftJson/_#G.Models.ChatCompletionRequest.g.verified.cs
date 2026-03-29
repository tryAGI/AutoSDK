//HintName: G.Models.ChatCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI-compatible chat completion request - exactly matching OpenAI's schema.
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// ID of the model to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Messages comprising the conversation so far
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionDeveloperMessageParam, global::G.ChatCompletionSystemMessageParam, global::G.ChatCompletionUserMessageParam, global::G.ChatCompletionAssistantMessageParam, global::G.ChatCompletionToolMessageParam, global::G.ChatCompletionFunctionMessageParam>> Messages { get; set; } = default!;

        /// <summary>
        /// Sampling temperature
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Number of chat completion choices to generate<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// Whether to stream back partial progress<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Sequences where the API will stop generating
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Stop { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Presence penalty
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Frequency penalty
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use
        /// </param>
        /// <param name="messages">
        /// Messages comprising the conversation so far
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter
        /// </param>
        /// <param name="n">
        /// Number of chat completion choices to generate<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Sequences where the API will stop generating
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user
        /// </param>
        public ChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionDeveloperMessageParam, global::G.ChatCompletionSystemMessageParam, global::G.ChatCompletionUserMessageParam, global::G.ChatCompletionAssistantMessageParam, global::G.ChatCompletionToolMessageParam, global::G.ChatCompletionFunctionMessageParam>> messages,
            double? temperature,
            double? topP,
            int? n,
            bool? stream,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop,
            int? maxTokens,
            double? presencePenalty,
            double? frequencyPenalty,
            string? user)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.Stream = stream;
            this.Stop = stop;
            this.MaxTokens = maxTokens;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}