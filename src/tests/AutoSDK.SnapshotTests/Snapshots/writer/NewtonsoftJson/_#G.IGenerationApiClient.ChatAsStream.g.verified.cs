//HintName: G.IGenerationApiClient.ChatAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationApiClient
    {
        /// <summary>
        /// Chat completion<br/>
        /// Generate a chat completion based on the provided messages. The response shown below is for non-streaming. To learn about streaming responses, see the [chat completion guide](https://dev.writer.com/home/chat-completion).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/chat \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"model":"palmyra-x5","messages":[{"content":"Write a memo summarizing this earnings report.","role":"user"}]}'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatCompletionChunk> ChatAsStreamAsync(

            global::G.ChatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat completion<br/>
        /// Generate a chat completion based on the provided messages. The response shown below is for non-streaming. To learn about streaming responses, see the [chat completion guide](https://dev.writer.com/home/chat-completion).
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.ChatCompletionChunk> ChatAsStreamAsync(
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            int? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            int? n = default,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop = default,
            bool? logprobs = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::G.ToolChoice? toolChoice = default,
            global::G.StreamOptions? streamOptions = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}