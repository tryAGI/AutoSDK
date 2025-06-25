//HintName: G.IApi.Chatv2.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Chat V2 API<br/>
        /// Generates a text response to a user message and streams it down, token by token. To learn how to use the Chat API with streaming follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).<br/>
        /// Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.ChatResponse, global::G.StreamedChatResponseV2?>> Chatv2Async(
            global::G.Chatv2Request request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat V2 API<br/>
        /// Generates a text response to a user message and streams it down, token by token. To learn how to use the Chat API with streaming follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).<br/>
        /// Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="citationOptions">
        /// Options for controlling citation generation.
        /// </param>
        /// <param name="documents">
        /// A list of relevant documents that the model can cite to generate a more accurate reply. Each document is either a string or document object with content and metadata.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.
        /// </param>
        /// <param name="k">
        /// Ensures that only the top `k` most likely tokens are considered for generation at each step. When `k` is set to `0`, k-sampling is disabled.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="logprobs">
        /// Defaults to `false`. When set to `true`, the log probabilities of the generated tokens will be included in the response.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model will generate as part of the response.<br/>
        /// **Note**: Setting a low value may result in incomplete generations.
        /// </param>
        /// <param name="messages">
        /// A list of chat messages in chronological order, representing a conversation between the user and the model.<br/>
        /// Messages can be from `User`, `Assistant`, `Tool` and `System` roles. Learn more about messages and roles in [the Chat API guide](https://docs.cohere.com/v2/docs/chat-api).
        /// </param>
        /// <param name="model">
        /// The name of a compatible [Cohere model](https://docs.cohere.com/v2/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/v2/docs/chat-fine-tuning) model.
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Default Value: 0.75F
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.
        /// </param>
        /// <param name="reasoningEffort">
        /// The reasoning effort level of the model. This affects the model's performance and the time it takes to generate a response.
        /// </param>
        /// <param name="responseFormat">
        /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/v2/docs/command-r), [Command R+](https://docs.cohere.com/v2/docs/command-r-plus) and newer models.<br/>
        /// The model can be forced into outputting JSON objects by setting `{ "type": "json_object" }`.<br/>
        /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
        /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
        /// **Note**: When `json_schema` is not specified, the generated object can have up to 5 layers of nesting.<br/>
        /// **Limitation**: The parameter is not supported when used in combinations with the `documents` or `tools` parameters.
        /// </param>
        /// <param name="safetyMode">
        /// Used to select the [safety instruction](https://docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
        /// When `OFF` is specified, the safety instruction will be omitted.<br/>
        /// Safety modes are not yet configurable in combination with `tools` and `documents` parameters.<br/>
        /// **Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).<br/>
        /// **Note**: `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.
        /// </param>
        /// <param name="seed">
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.
        /// </param>
        /// <param name="stopSequences">
        /// A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.
        /// </param>
        /// <param name="stream">
        /// Defaults to `false`.<br/>
        /// When `true`, the response will be a SSE stream of events.<br/>
        /// Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.
        /// </param>
        /// <param name="strictTools">
        /// When set to `true`, tool calls in the Assistant message will be forced to follow the tool definition strictly. Learn more in the [Structured Outputs (Tools) guide](https://docs.cohere.com/docs/structured-outputs-json#structured-outputs-tools).<br/>
        /// **Note**: The first few requests with a new set of tools will take longer to process.
        /// </param>
        /// <param name="temperature">
        /// Defaults to `0.3`.<br/>
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.<br/>
        /// Randomness can be further maximized by increasing the  value of the `p` parameter.
        /// </param>
        /// <param name="toolChoice">
        /// Used to control whether or not the model will be forced to use a tool when answering. When `REQUIRED` is specified, the model will be forced to use at least one of the user-defined tools, and the `tools` parameter must be passed in the request.<br/>
        /// When `NONE` is specified, the model will be forced **not** to use one of the specified tools, and give a direct response.<br/>
        /// If tool_choice isn't specified, then the model is free to choose whether to use the specified tools or not.<br/>
        /// **Note**: This parameter is only compatible with models [Command-r7b](https://docs.cohere.com/v2/docs/command-r7b) and newer.<br/>
        /// **Note**: The same functionality can be achieved in `/v1/chat` using the `force_single_step` parameter. If `force_single_step=true`, this is equivalent to specifying `REQUIRED`. While if `force_single_step=true` and `tool_results` are passed, this is equivalent to specifying `NONE`.
        /// </param>
        /// <param name="tools">
        /// A list of tools (functions) available to the model. The model response may contain 'tool_calls' to the specified tools.<br/>
        /// Learn more in the [Tool Use guide](https://docs.cohere.com/docs/tools).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OneOf<global::G.ChatResponse, global::G.StreamedChatResponseV2?>> Chatv2Async(
            global::System.Collections.Generic.IList<global::G.ChatMessageV2> messages,
            string model,
            string? xClientName = default,
            global::G.CitationOptions? citationOptions = default,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.Document>>? documents = default,
            float? frequencyPenalty = default,
            int? k = default,
            bool? logprobs = default,
            int? maxTokens = default,
            float? p = default,
            float? presencePenalty = default,
            global::G.ReasoningEffort? reasoningEffort = default,
            global::G.ResponseFormatV2? responseFormat = default,
            global::G.Chatv2RequestSafetyMode? safetyMode = default,
            int? seed = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            bool? stream = default,
            bool? strictTools = default,
            float? temperature = default,
            global::G.Chatv2RequestToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.ToolV2>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}