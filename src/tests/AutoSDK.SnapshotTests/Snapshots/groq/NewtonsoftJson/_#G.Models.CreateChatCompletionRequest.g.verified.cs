//HintName: G.Models.CreateChatCompletionRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> Messages { get; set; } = default!;

        /// <summary>
        /// ID of the model to use. For details on which models are compatible with the Chat API, see available [models](https://console.groq.com/docs/models)<br/>
        /// Example: meta-llama/llama-4-scout-17b-16e-instruct
        /// </summary>
        /// <example>meta-llama/llama-4-scout-17b-16e-instruct</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?> Model { get; set; } = default!;

        /// <summary>
        /// If set to true, groq will return called tools without validating that the tool is present in request.tools. tool_choice=required/none will still be enforced, but the request cannot require a specific tool be used.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_tool_validation")]
        public bool? DisableToolValidation { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models. Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Whether to include reasoning in the response.  If true, the response will include a `reasoning` field. If false, the model's reasoning will not be included in the response.<br/>
        /// This field is mutually exclusive with `reasoning_format`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_reasoning")]
        public bool? IncludeReasoning { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models.<br/>
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, int>? LogitBias { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models.<br/>
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models.<br/>
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Deprecated in favor of `max_completion_tokens`.<br/>
        /// The maximum number of tokens that can be generated in the chat completion. The total length of input tokens and generated tokens is limited by the model's context length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The maximum number of tokens that can be generated in the chat completion. The total length of input tokens and generated tokens is limited by the model's context length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// How many chat completion choices to generate for each input message. Note that the current moment, only n=1 is supported. Other values will result in a 400 response.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// This is not yet supported by any of our models. Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output. Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. `json_schema` response format is only available on [supported models](https://console.groq.com/docs/structured-outputs#supported-models). Setting to `{ "type": "json_object" }` enables the older JSON mode, which ensures the message the model generates is valid JSON. Using `json_schema` is preferred for models that support it.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? ResponseFormat { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The service tier to use for the request. Defaults to `on_demand`.<br/>
        /// - `auto` will automatically select the highest tier available within the rate limits of your organization.<br/>
        /// - `flex` uses the flex tier, which will succeed or fail quickly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public global::G.CreateChatCompletionRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// qwen3 models support the following values<br/>
        /// Set to 'none' to disable reasoning.<br/>
        /// Set to 'default' or null to let Qwen reason.<br/>
        /// openai/gpt-oss-20b and openai/gpt-oss-120b support 'low', 'medium', or 'high'.<br/>
        /// 'medium' is the default value.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        public global::G.CreateChatCompletionRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Specifies how to output reasoning tokens<br/>
        /// This field is mutually exclusive with `include_reasoning`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_format")]
        public global::G.CreateChatCompletionRequestReasoningFormat? ReasoningFormat { get; set; }

        /// <summary>
        /// If set, partial message deltas will be sent. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example code](/docs/text-chat#streaming-a-chat-completion).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or top_p but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tool and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools.<br/>
        /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// `none` is the default when no tools are present. `auto` is the default if tools are present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public global::G.ChatCompletionToolChoiceOption? ToolChoice { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Deprecated in favor of `tool_choice`.<br/>
        /// Controls which (if any) function is called by the model.<br/>
        /// `none` means the model will not call a function and instead generates a message.<br/>
        /// `auto` means the model can pick between generating a message or calling a function.<br/>
        /// Specifying a particular function via `{"name": "my_function"}` forces the model to call that function.<br/>
        /// `none` is the default when no functions are present. `auto` is the default if functions are present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        public global::G.OneOf<global::G.CreateChatCompletionRequestFunctionCall?, global::G.ChatCompletionFunctionCallOption>? FunctionCall { get; set; }

        /// <summary>
        /// Deprecated in favor of `tools`.<br/>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// This parameter is not currently supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// This parameter is not currently supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Deprecated: Use search_settings.include_domains instead.<br/>
        /// A list of domains to include in the search results when the model uses a web search tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_domains")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Deprecated: Use search_settings.exclude_domains instead.<br/>
        /// A list of domains to exclude from the search results when the model uses a web search tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_domains")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Settings for web search functionality when the model uses a web search tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_settings")]
        public global::G.CreateChatCompletionRequestSearchSettings? SearchSettings { get; set; }

        /// <summary>
        /// Custom configuration of models and tools for Compound.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compound_custom")]
        public global::G.CreateChatCompletionRequestCompoundCustom? CompoundCustom { get; set; }

        /// <summary>
        /// A list of documents to provide context for the conversation. Each document contains text that can be referenced by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionDocument>? Documents { get; set; }

        /// <summary>
        /// Whether to enable citations in the response. When enabled, the model will include citations for information retrieved from provided documents or web searches.<br/>
        /// Default Value: enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citation_options")]
        public global::G.CreateChatCompletionRequestCitationOptions? CitationOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. For details on which models are compatible with the Chat API, see available [models](https://console.groq.com/docs/models)<br/>
        /// Example: meta-llama/llama-4-scout-17b-16e-instruct
        /// </param>
        /// <param name="disableToolValidation">
        /// If set to true, groq will return called tools without validating that the tool is present in request.tools. tool_choice=required/none will still be enforced, but the request cannot require a specific tool be used.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="frequencyPenalty">
        /// This is not yet supported by any of our models. Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includeReasoning">
        /// Whether to include reasoning in the response.  If true, the response will include a `reasoning` field. If false, the model's reasoning will not be included in the response.<br/>
        /// This field is mutually exclusive with `reasoning_format`.
        /// </param>
        /// <param name="logitBias">
        /// This is not yet supported by any of our models.<br/>
        /// Modify the likelihood of specified tokens appearing in the completion.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="logprobs">
        /// This is not yet supported by any of our models.<br/>
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// This is not yet supported by any of our models.<br/>
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens that can be generated in the chat completion. The total length of input tokens and generated tokens is limited by the model's context length.
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that the current moment, only n=1 is supported. Other values will result in a 400 response.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="presencePenalty">
        /// This is not yet supported by any of our models. Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output. Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. `json_schema` response format is only available on [supported models](https://console.groq.com/docs/structured-outputs#supported-models). Setting to `{ "type": "json_object" }` enables the older JSON mode, which ensures the message the model generates is valid JSON. Using `json_schema` is preferred for models that support it.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.<br/>
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for the request. Defaults to `on_demand`.<br/>
        /// - `auto` will automatically select the highest tier available within the rate limits of your organization.<br/>
        /// - `flex` uses the flex tier, which will succeed or fail quickly.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reasoningEffort">
        /// qwen3 models support the following values<br/>
        /// Set to 'none' to disable reasoning.<br/>
        /// Set to 'default' or null to let Qwen reason.<br/>
        /// openai/gpt-oss-20b and openai/gpt-oss-120b support 'low', 'medium', or 'high'.<br/>
        /// 'medium' is the default value.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reasoningFormat">
        /// Specifies how to output reasoning tokens<br/>
        /// This field is mutually exclusive with `include_reasoning`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example code](/docs/text-chat#streaming-a-chat-completion).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or top_p but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
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
        /// Whether to enable parallel function calling during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </param>
        /// <param name="metadata">
        /// This parameter is not currently supported.
        /// </param>
        /// <param name="store">
        /// This parameter is not currently supported.
        /// </param>
        /// <param name="searchSettings">
        /// Settings for web search functionality when the model uses a web search tool.
        /// </param>
        /// <param name="compoundCustom">
        /// Custom configuration of models and tools for Compound.
        /// </param>
        /// <param name="documents">
        /// A list of documents to provide context for the conversation. Each document contains text that can be referenced by the model.
        /// </param>
        /// <param name="citationOptions">
        /// Whether to enable citations in the response. When enabled, the model will include citations for information retrieved from provided documents or web searches.<br/>
        /// Default Value: enabled
        /// </param>
        public CreateChatCompletionRequest(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?> model,
            bool? disableToolValidation,
            double? frequencyPenalty,
            bool? includeReasoning,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            bool? logprobs,
            int? topLogprobs,
            int? maxCompletionTokens,
            int? n,
            double? presencePenalty,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? responseFormat,
            int? seed,
            global::G.CreateChatCompletionRequestServiceTier? serviceTier,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            global::G.CreateChatCompletionRequestReasoningEffort? reasoningEffort,
            global::G.CreateChatCompletionRequestReasoningFormat? reasoningFormat,
            bool? stream,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.ChatCompletionToolChoiceOption? toolChoice,
            bool? parallelToolCalls,
            string? user,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            bool? store,
            global::G.CreateChatCompletionRequestSearchSettings? searchSettings,
            global::G.CreateChatCompletionRequestCompoundCustom? compoundCustom,
            global::System.Collections.Generic.IList<global::G.ChatCompletionDocument>? documents,
            global::G.CreateChatCompletionRequestCitationOptions? citationOptions)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.DisableToolValidation = disableToolValidation;
            this.FrequencyPenalty = frequencyPenalty;
            this.IncludeReasoning = includeReasoning;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.N = n;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.ServiceTier = serviceTier;
            this.Stop = stop;
            this.ReasoningEffort = reasoningEffort;
            this.ReasoningFormat = reasoningFormat;
            this.Stream = stream;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.User = user;
            this.Metadata = metadata;
            this.Store = store;
            this.SearchSettings = searchSettings;
            this.CompoundCustom = compoundCustom;
            this.Documents = documents;
            this.CitationOptions = citationOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}