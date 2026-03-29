//HintName: G.Models.ChatCompletionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionsRequest
    {
        /// <summary>
        /// The chat model to use for generating completions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages Messages { get; set; }

        /// <summary>
        /// A value between -2.0 and 2.0, with positive values increasingly penalizing new tokens based on their frequency so far in order to decrease further occurrences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Modifies the likelihood of specified tokens appearing in a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias? LogitBias { get; set; }

        /// <summary>
        /// The maximum number of tokens in the generated completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A value between -2.0 and 2.0, with positive values causing a flat reduction of new tokens based on their existing presence so far in order to decrease further occurrences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Constrains effort on reasoning for reasoning models. Currently supported values are `low`, `medium`, and `high`. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Only supported by reasoning models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public string? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopJsonConverter))]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop? Stop { get; set; }

        /// <summary>
        /// Whether to stream back the model response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Extra parameters used when streaming the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceJsonConverter))]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// The content of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems>? Tools { get; set; }

        /// <summary>
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The diversity of the generated text based on top-k sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Options to affect the output of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput? Output { get; set; }

        /// <summary>
        /// Options to affect the input of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput? Input { get; set; }

        /// <summary>
        /// Deprecated. Please use max_completion_tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The chat model to use for generating completions.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="frequencyPenalty">
        /// A value between -2.0 and 2.0, with positive values increasingly penalizing new tokens based on their frequency so far in order to decrease further occurrences.
        /// </param>
        /// <param name="logitBias">
        /// Modifies the likelihood of specified tokens appearing in a response.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens in the generated completion.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use.
        /// </param>
        /// <param name="presencePenalty">
        /// A value between -2.0 and 2.0, with positive values causing a flat reduction of new tokens based on their existing presence so far in order to decrease further occurrences.
        /// </param>
        /// <param name="reasoningEffort">
        /// Constrains effort on reasoning for reasoning models. Currently supported values are `low`, `medium`, and `high`. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Only supported by reasoning models.
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Whether to stream back the model response.
        /// </param>
        /// <param name="streamOptions">
        /// Extra parameters used when streaming the response.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="tools">
        /// The content of the tool call.
        /// </param>
        /// <param name="topP">
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </param>
        /// <param name="topK">
        /// The diversity of the generated text based on top-k sampling.
        /// </param>
        /// <param name="output">
        /// Options to affect the output of the response.
        /// </param>
        /// <param name="input">
        /// Options to affect the input of the request.
        /// </param>
        /// <param name="maxTokens">
        /// Deprecated. Please use max_completion_tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsRequest(
            string model,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages messages,
            double? frequencyPenalty,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias? logitBias,
            int? maxCompletionTokens,
            bool? parallelToolCalls,
            double? presencePenalty,
            string? reasoningEffort,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop? stop,
            bool? stream,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions? streamOptions,
            double? temperature,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems>? tools,
            double? topP,
            int? topK,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput? output,
            global::G.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput? input,
            int? maxTokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages;
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.PresencePenalty = presencePenalty;
            this.ReasoningEffort = reasoningEffort;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopP = topP;
            this.TopK = topK;
            this.Output = output;
            this.Input = input;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsRequest" /> class.
        /// </summary>
        public ChatCompletionsRequest()
        {
        }
    }
}