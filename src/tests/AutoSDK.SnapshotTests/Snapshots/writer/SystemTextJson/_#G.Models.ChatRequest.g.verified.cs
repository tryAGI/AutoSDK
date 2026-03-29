//HintName: G.Models.ChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// The [ID of the model](https://dev.writer.com/home/models) to use for creating the chat completion. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// An array of message objects that form the conversation history or context for the model to respond to. The array must contain at least one message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatMessage> Messages { get; set; }

        /// <summary>
        /// Defines the maximum number of tokens (words and characters) that the model can generate in the response. This can be adjusted to allow for longer or shorter responses as needed. The maximum value varies by model. See the [models overview](/home/models) for more information about the maximum number of tokens for each model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Controls the randomness or creativity of the model's responses. A higher temperature results in more varied and less predictable text, while a lower temperature produces more deterministic and conservative outputs.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Sets the threshold for "nucleus sampling," a technique to focus the model's token generation on the most likely subset of tokens. Only tokens with cumulative probability above this threshold are considered, controlling the trade-off between creativity and coherence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Specifies the number of completions (responses) to generate from the model in a single request. This parameter allows for generating multiple responses, offering a variety of potential replies from which to choose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// A token or sequence of tokens that, when generated, will cause the model to stop producing further content. This can be a single token or an array of tokens, acting as a signal to end the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        public global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? Stop { get; set; }

        /// <summary>
        /// Specifies whether to return log probabilities of the output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed incrementally as it is generated or only returned once fully complete. Streaming can be useful for providing real-time feedback in interactive applications.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// An array containing tool definitions for tools that the model can use to generate responses. The tool definitions use JSON schema. You can define your own functions or use one of the built-in `graph`, `llm`, `translation`, or `vision` tools. Note that you can only use one built-in tool type in the array (only one of `graph`, `llm`, `translation`, or `vision`). You can pass multiple [custom tools](https://dev.writer.com/home/tool-calling) of type `function` in the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// Configure how the model will call functions:<br/>
        /// - `auto`: allows the model to automatically choose the tool to use, or not call a tool<br/>
        /// - `none`: disables tool calling; the model will instead generate a message<br/>
        /// - `required`: requires the model to call one or more tools<br/>
        /// You can also use a JSON object to force the model to call a specific tool. For example, `{"type": "function", "function": {"name": "get_current_weather"}}` requires the model to call the `get_current_weather` function, regardless of the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolChoiceJsonConverter))]
        public global::G.ToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Additional options for streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::G.StreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// The response format to use for the chat completion, available with `palmyra-x4` and `palmyra-x5`.<br/>
        /// `text` is the default response format. [JSON Schema](https://json-schema.org/) is supported for structured responses. If you specify `json_schema`, you must also provide a `json_schema` object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The [ID of the model](https://dev.writer.com/home/models) to use for creating the chat completion. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.
        /// </param>
        /// <param name="messages">
        /// An array of message objects that form the conversation history or context for the model to respond to. The array must contain at least one message.
        /// </param>
        /// <param name="maxTokens">
        /// Defines the maximum number of tokens (words and characters) that the model can generate in the response. This can be adjusted to allow for longer or shorter responses as needed. The maximum value varies by model. See the [models overview](/home/models) for more information about the maximum number of tokens for each model.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness or creativity of the model's responses. A higher temperature results in more varied and less predictable text, while a lower temperature produces more deterministic and conservative outputs.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Sets the threshold for "nucleus sampling," a technique to focus the model's token generation on the most likely subset of tokens. Only tokens with cumulative probability above this threshold are considered, controlling the trade-off between creativity and coherence.
        /// </param>
        /// <param name="n">
        /// Specifies the number of completions (responses) to generate from the model in a single request. This parameter allows for generating multiple responses, offering a variety of potential replies from which to choose.
        /// </param>
        /// <param name="stop">
        /// A token or sequence of tokens that, when generated, will cause the model to stop producing further content. This can be a single token or an array of tokens, acting as a signal to end the output.
        /// </param>
        /// <param name="logprobs">
        /// Specifies whether to return log probabilities of the output tokens.
        /// </param>
        /// <param name="stream">
        /// Indicates whether the response should be streamed incrementally as it is generated or only returned once fully complete. Streaming can be useful for providing real-time feedback in interactive applications.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// An array containing tool definitions for tools that the model can use to generate responses. The tool definitions use JSON schema. You can define your own functions or use one of the built-in `graph`, `llm`, `translation`, or `vision` tools. Note that you can only use one built-in tool type in the array (only one of `graph`, `llm`, `translation`, or `vision`). You can pass multiple [custom tools](https://dev.writer.com/home/tool-calling) of type `function` in the same request.
        /// </param>
        /// <param name="toolChoice">
        /// Configure how the model will call functions:<br/>
        /// - `auto`: allows the model to automatically choose the tool to use, or not call a tool<br/>
        /// - `none`: disables tool calling; the model will instead generate a message<br/>
        /// - `required`: requires the model to call one or more tools<br/>
        /// You can also use a JSON object to force the model to call a specific tool. For example, `{"type": "function", "function": {"name": "get_current_weather"}}` requires the model to call the `get_current_weather` function, regardless of the prompt.
        /// </param>
        /// <param name="streamOptions">
        /// Additional options for streaming.
        /// </param>
        /// <param name="responseFormat">
        /// The response format to use for the chat completion, available with `palmyra-x4` and `palmyra-x5`.<br/>
        /// `text` is the default response format. [JSON Schema](https://json-schema.org/) is supported for structured responses. If you specify `json_schema`, you must also provide a `json_schema` object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequest(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            int? maxTokens,
            double? temperature,
            double? topP,
            int? n,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop,
            bool? logprobs,
            bool? stream,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.ToolChoice? toolChoice,
            global::G.StreamOptions? streamOptions,
            global::G.ResponseFormat? responseFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.Stop = stop;
            this.Logprobs = logprobs;
            this.Stream = stream;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.StreamOptions = streamOptions;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        public ChatRequest()
        {
        }
    }
}