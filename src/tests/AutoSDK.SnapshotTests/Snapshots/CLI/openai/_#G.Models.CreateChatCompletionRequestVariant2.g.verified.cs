﻿//HintName: G.Models.CreateChatCompletionRequestVariant2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequestVariant2
    {
        /// <summary>
        /// A list of messages comprising the conversation so far. Depending on the<br/>
        /// [model](/docs/models) you use, different message types (modalities) are<br/>
        /// supported, like [text](/docs/guides/text-generation),<br/>
        /// [images](/docs/guides/vision), and [audio](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelIdsSharedJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelIdsShared Model { get; set; }

        /// <summary>
        /// Output types that you would like the model to generate.<br/>
        /// Most models are capable of generating text, which is the default:<br/>
        /// `["text"]`<br/>
        /// The `gpt-4o-audio-preview` model can also be used to <br/>
        /// [generate audio](/docs/guides/audio). To request that this model generate <br/>
        /// both text and audio responses, you can use:<br/>
        /// `["text", "audio"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::G.ResponseModalitie>? Modalities { get; set; }

        /// <summary>
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningEffortJsonConverter))]
        public global::G.ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// their existing frequency in the text so far, decreasing the model's<br/>
        /// likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// whether they appear in the text so far, increasing the model's likelihood<br/>
        /// to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// This tool searches the web for relevant results to use in a response.<br/>
        /// Learn more about the [web search tool](/docs/guides/tools-web-search?api-mode=chat).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_options")]
        public global::G.CreateChatCompletionRequestVariant2WebSearchOptions? WebSearchOptions { get; set; }

        /// <summary>
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.<br/>
        /// `logprobs` must be set to `true` if this parameter is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>))]
        public global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? ResponseFormat { get; set; }

        /// <summary>
        /// Parameters for audio output. Required when audio output is requested with<br/>
        /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.CreateChatCompletionRequestVariant2Audio? Audio { get; set; }

        /// <summary>
        /// Whether or not to store the output of this chat completion request for <br/>
        /// use in our [model distillation](/docs/guides/distillation) or<br/>
        /// [evals](/docs/guides/evals) products.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section below](/docs/api-reference/chat/streaming)<br/>
        /// for more information, along with the [streaming responses](/docs/guides/streaming-responses)<br/>
        /// guide for more information on how to handle the streaming events.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Not supported with latest reasoning models `o3` and `o4-mini`.<br/>
        /// Up to 4 sequences where the API will stop generating further tokens. The<br/>
        /// returned text will not contain the stop sequence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StopConfigurationJsonConverter))]
        public global::G.StopConfiguration? Stop { get; set; }

        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the<br/>
        /// tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
        /// the bias is added to the logits generated by the model prior to sampling.<br/>
        /// The exact effect will vary per model, but values between -1 and 1 should<br/>
        /// decrease or increase likelihood of selection; values like -100 or 100<br/>
        /// should result in a ban or exclusive selection of the relevant token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, int>? LogitBias { get; set; }

        /// <summary>
        /// Whether to return log probabilities of the output tokens or not. If true,<br/>
        /// returns the log probabilities of each output token returned in the<br/>
        /// `content` of `message`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// The maximum number of [tokens](/tokenizer) that can be generated in the<br/>
        /// chat completion. This value can be used to control<br/>
        /// [costs](https://openai.com/api/pricing/) for text generated via API.<br/>
        /// This value is now deprecated in favor of `max_completion_tokens`, and is<br/>
        /// not compatible with [o-series models](/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Configuration for a [Predicted Output](/docs/guides/predicted-outputs),<br/>
        /// which can greatly improve response times when large parts of the model<br/>
        /// response are known ahead of time. This is most common when you are<br/>
        /// regenerating a file with only minor changes to most of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public global::G.PredictionContent? Prediction { get; set; }

        /// <summary>
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Options for streaming response. Only set this when you set `stream: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::G.ChatCompletionStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionToolChoiceOptionJsonConverter))]
        public global::G.ChatCompletionToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Deprecated in favor of `tool_choice`.<br/>
        /// Controls which (if any) function is called by the model.<br/>
        /// `none` means the model will not call a function and instead generates a<br/>
        /// message.<br/>
        /// `auto` means the model can pick between generating a message or calling a<br/>
        /// function.<br/>
        /// Specifying a particular function via `{"name": "my_function"}` forces the<br/>
        /// model to call that function.<br/>
        /// `none` is the default when no functions are present. `auto` is the default<br/>
        /// if functions are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateChatCompletionRequestVariant2FunctionCall?, global::G.ChatCompletionFunctionCallOption>))]
        public global::G.OneOf<global::G.CreateChatCompletionRequestVariant2FunctionCall?, global::G.ChatCompletionFunctionCallOption>? FunctionCall { get; set; }

        /// <summary>
        /// Deprecated in favor of `tools`.<br/>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far. Depending on the<br/>
        /// [model](/docs/models) you use, different message types (modalities) are<br/>
        /// supported, like [text](/docs/guides/text-generation),<br/>
        /// [images](/docs/guides/vision), and [audio](/docs/guides/audio).
        /// </param>
        /// <param name="model">
        /// Example: gpt-4o
        /// </param>
        /// <param name="modalities">
        /// Output types that you would like the model to generate.<br/>
        /// Most models are capable of generating text, which is the default:<br/>
        /// `["text"]`<br/>
        /// The `gpt-4o-audio-preview` model can also be used to <br/>
        /// [generate audio](/docs/guides/audio). To request that this model generate <br/>
        /// both text and audio responses, you can use:<br/>
        /// `["text", "audio"]`
        /// </param>
        /// <param name="reasoningEffort">
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="maxCompletionTokens">
        /// An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// their existing frequency in the text so far, decreasing the model's<br/>
        /// likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on<br/>
        /// whether they appear in the text so far, increasing the model's likelihood<br/>
        /// to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="webSearchOptions">
        /// This tool searches the web for relevant results to use in a response.<br/>
        /// Learn more about the [web search tool](/docs/guides/tools-web-search?api-mode=chat).
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.<br/>
        /// `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </param>
        /// <param name="audio">
        /// Parameters for audio output. Required when audio output is requested with<br/>
        /// `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
        /// </param>
        /// <param name="store">
        /// Whether or not to store the output of this chat completion request for <br/>
        /// use in our [model distillation](/docs/guides/distillation) or<br/>
        /// [evals](/docs/guides/evals) products.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section below](/docs/api-reference/chat/streaming)<br/>
        /// for more information, along with the [streaming responses](/docs/guides/streaming-responses)<br/>
        /// guide for more information on how to handle the streaming events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Not supported with latest reasoning models `o3` and `o4-mini`.<br/>
        /// Up to 4 sequences where the API will stop generating further tokens. The<br/>
        /// returned text will not contain the stop sequence.
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Accepts a JSON object that maps tokens (specified by their token ID in the<br/>
        /// tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
        /// the bias is added to the logits generated by the model prior to sampling.<br/>
        /// The exact effect will vary per model, but values between -1 and 1 should<br/>
        /// decrease or increase likelihood of selection; values like -100 or 100<br/>
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true,<br/>
        /// returns the log probabilities of each output token returned in the<br/>
        /// `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="prediction">
        /// Configuration for a [Predicted Output](/docs/guides/predicted-outputs),<br/>
        /// which can greatly improve response times when large parts of the model<br/>
        /// response are known ahead of time. This is most common when you are<br/>
        /// regenerating a file with only minor changes to most of the content.
        /// </param>
        /// <param name="seed">
        /// This feature is in Beta.<br/>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming response. Only set this when you set `stream: true`.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestVariant2(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            global::G.ModelIdsShared model,
            global::System.Collections.Generic.IList<global::G.ResponseModalitie>? modalities,
            global::G.ReasoningEffort? reasoningEffort,
            int? maxCompletionTokens,
            double? frequencyPenalty,
            double? presencePenalty,
            global::G.CreateChatCompletionRequestVariant2WebSearchOptions? webSearchOptions,
            int? topLogprobs,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? responseFormat,
            global::G.CreateChatCompletionRequestVariant2Audio? audio,
            bool? store,
            bool? stream,
            global::G.StopConfiguration? stop,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            bool? logprobs,
            int? n,
            global::G.PredictionContent? prediction,
            int? seed,
            global::G.ChatCompletionStreamOptions? streamOptions,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.ChatCompletionToolChoiceOption? toolChoice,
            bool? parallelToolCalls)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.Modalities = modalities;
            this.ReasoningEffort = reasoningEffort;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.WebSearchOptions = webSearchOptions;
            this.TopLogprobs = topLogprobs;
            this.ResponseFormat = responseFormat;
            this.Audio = audio;
            this.Store = store;
            this.Stream = stream;
            this.Stop = stop;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.N = n;
            this.Prediction = prediction;
            this.Seed = seed;
            this.StreamOptions = streamOptions;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2()
        {
        }
    }
}