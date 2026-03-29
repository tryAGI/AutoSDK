//HintName: G.IChatClient.CreateChatCompletion.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(

            global::G.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a model response for the given chat conversation.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?> model,
            bool? disableToolValidation = default,
            double? frequencyPenalty = default,
            bool? includeReasoning = default,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxCompletionTokens = default,
            int? n = default,
            double? presencePenalty = default,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? responseFormat = default,
            int? seed = default,
            global::G.CreateChatCompletionRequestServiceTier? serviceTier = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            global::G.CreateChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::G.CreateChatCompletionRequestReasoningFormat? reasoningFormat = default,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools = default,
            global::G.ChatCompletionToolChoiceOption? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            bool? store = default,
            global::G.CreateChatCompletionRequestSearchSettings? searchSettings = default,
            global::G.CreateChatCompletionRequestCompoundCustom? compoundCustom = default,
            global::System.Collections.Generic.IList<global::G.ChatCompletionDocument>? documents = default,
            global::G.CreateChatCompletionRequestCitationOptions? citationOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}