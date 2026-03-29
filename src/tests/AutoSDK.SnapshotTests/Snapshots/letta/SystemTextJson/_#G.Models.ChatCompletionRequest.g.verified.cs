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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Messages comprising the conversation so far
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionDeveloperMessageParam, global::G.ChatCompletionSystemMessageParam, global::G.ChatCompletionUserMessageParam, global::G.ChatCompletionAssistantMessageParam, global::G.ChatCompletionToolMessageParam, global::G.ChatCompletionFunctionMessageParam>> Messages { get; set; }

        /// <summary>
        /// Sampling temperature
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Number of chat completion choices to generate<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Whether to stream back partial progress<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Sequences where the API will stop generating
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Stop { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Presence penalty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Frequency penalty
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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