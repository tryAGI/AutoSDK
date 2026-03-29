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
        /// The model to use for chat completion.<br/>
        /// Available models: solar-pro, solar-mini, solar-mini-ja<br/>
        /// Example: solar-pro
        /// </summary>
        /// <example>solar-pro</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatMessage> Messages { get; set; }

        /// <summary>
        /// Sampling temperature between 0 and 2. Higher values make output more random.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter. Only tokens with top_p probability mass are considered.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// How many chat completion choices to generate for each input message.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// If specified, the system will make a best effort to sample deterministically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Penalizes new tokens based on their existing frequency in the text so far.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Penalizes new tokens based on whether they appear in the text so far.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A list of tools the model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>))]
        public global::G.OneOf<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for chat completion.<br/>
        /// Available models: solar-pro, solar-mini, solar-mini-ja<br/>
        /// Example: solar-pro
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 2. Higher values make output more random.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. Only tokens with top_p probability mass are considered.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate in the response.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// If specified, the system will make a best effort to sample deterministically.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalizes new tokens based on their existing frequency in the text so far.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="presencePenalty">
        /// Penalizes new tokens based on whether they appear in the text so far.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            double? temperature,
            double? topP,
            int? maxTokens,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            int? n,
            int? seed,
            double? frequencyPenalty,
            double? presencePenalty,
            global::G.ResponseFormat? responseFormat,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.OneOf<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>? toolChoice)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.Stop = stop;
            this.Stream = stream;
            this.N = n;
            this.Seed = seed;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
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